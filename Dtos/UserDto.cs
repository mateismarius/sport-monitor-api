namespace SportMonitorAPI.Dtos
{
    public class UserDto
    {
        public string Email { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public IList<string>? Roles { get; set; }
    }
}
