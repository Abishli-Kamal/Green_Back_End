using Microsoft.AspNetCore.Mvc;

namespace Green_Back_End.Areas.GreenAdmin.Controllers
{
    [Area("GreenAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
