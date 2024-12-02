using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
