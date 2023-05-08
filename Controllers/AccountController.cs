using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SportMonitorAPI.Dtos;
using SportMonitorAPI.Entities;
using SportMonitorAPI.Services;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using SportMonitorAPI.Errors;

namespace SportMonitorAPI.Controllers
{
    public class AccountController : BaseApiController
    {
        
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        /// <summary>
        /// Gestionează autentificarea utilizatorilor și generarea token-urilor de acces.
        /// </summary>
        /// <param name="model">Obiectul LoginDto care conține informațiile de autentificare ale utilizatorului.</param>
        /// <returns>Un obiect IActionResult care conține rezultatul operațiunii de autentificare și token-ul de acces.</returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            
            // Verifică dacă utilizatorul există și dacă parola este corectă.
            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
                return Unauthorized(new ApiResponse(401));
            var userRoles = await _userManager.GetRolesAsync(user);
            // Crearea listei de claims pentru token-ul de acces.
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            authClaims.AddRange(userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole)));

            var token = CreateToken(authClaims);

            _ = int.TryParse(_configuration["JWT:RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            await _userManager.UpdateAsync(user);
            // Returnează un obiect cu informațiile necesare și token-ul de acces.
            return Ok(new
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo,
                user.Email,
                Roles = userRoles
            });
        }
        /// <summary>
        /// Această metodă asincronă gestionează înregistrarea unui nou utilizator.
        /// </summary>
        /// <param name="model">Obiectul RegisterModel care conține informațiile necesare pentru înregistrarea utilizatorului.</param>
        /// <returns>Un obiect IActionResult care conține rezultatul operațiunii de înregistrare.</returns>
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Eroare", Message = "Utilizatorul este deja inregistrat!" });

            User user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Eroare", Message = "Crearea unui nou utilizator a esuat. Va rog sa verificati datele introduse!!" });

            return Ok(new { Status = "Succes", Message = "Utilizatorul a fost creat cu succes!", User = await _userManager.FindByNameAsync(user.UserName) });
        }

        /// <summary>
        /// Gestionează înregistrarea unui nou utilizator în rolul de Administrator.
        /// </summary>
        /// <param name="model">Obiectul RegisterModel care conține informațiile necesare pentru înregistrarea utilizatorului.</param>
        /// <returns>Un obiect IActionResult care conține rezultatul operațiunii de înregistrare.</returns>
        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            // Verifică dacă utilizatorul există deja.
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Utilizatorul exista deja!!" });
            // Creaza un nou obiect utilizator.
            User user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            
            // Înregistreaza un noul utilizator cu parola specificată.
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", 
                    Message = "Inregistrarea unui nou utilizator a esuat! Va rog sa verificati detaliile si sa incercati din nou!" });
            // Creaza rolurile Admin și User dacă acestea nu există.
            if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await _roleManager.RoleExistsAsync(UserRoles.User))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            // Atribuie rolurile de  Admin și User utilizatorului creat.
            if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await _userManager.AddToRoleAsync(user, UserRoles.Admin);
            }
            if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await _userManager.AddToRoleAsync(user, UserRoles.User);
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        /// <summary>
        /// Crează un token JWT pe baza unei liste de claims.
        /// </summary>
        /// <param name="authClaims">Lista de claims care trebuie incluse în token-ul JWT.</param>
        /// <returns>Un obiect JwtSecurityToken care conține token-ul creat.</returns>
        private JwtSecurityToken CreateToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            _ = int.TryParse(_configuration["JWT:TokenValidityInMinutes"], out int tokenValidityInMinutes);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(tokenValidityInMinutes),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        public class Response
        {
            public string? Status { get; set; }
            public string? Message { get; set; }
        }


        public class RegisterModel
        {
            [Required(ErrorMessage = "Acest camp este obligatoriu")]
            public string? Username { get; set; }

            [EmailAddress]
            [Required(ErrorMessage = "Acest camp este obligatoriu")]
            public string? Email { get; set; }

            [Required(ErrorMessage = "Acest camp este obligatoriu")]
            public string? Password { get; set; }
        }


        public static class UserRoles
        {
            public const string Admin = "Admin";
            public const string User = "User";
        }
    }
}

