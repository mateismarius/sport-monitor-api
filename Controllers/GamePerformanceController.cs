using Microsoft.AspNetCore.Mvc;

namespace SportMonitorAPI.Controllers
{
    public class GamePerformanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
