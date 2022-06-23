using Microsoft.AspNetCore.Mvc;

namespace Green_Back_End.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
