using Microsoft.AspNetCore.Mvc;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Errors;

namespace SportMonitorAPI.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly ApplicationContext _context;
        public BuggyController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var thing = _context.Players.Find(32);
            if (thing == null)
                return NotFound(new ApiResponse(404));
            return Ok();
        }
        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            return StatusCode(500);
        }
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }

        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "This is first error");
            ModelState.AddModelError("Problem2", "This is second error");
            return ValidationProblem();
        }

        [HttpGet("unauthorized")]
        public ActionResult GetUnaurhorized()
        {
            return Unauthorized(new ApiResponse(401));
        }
    }
}
