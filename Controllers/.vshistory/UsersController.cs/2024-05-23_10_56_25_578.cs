using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
