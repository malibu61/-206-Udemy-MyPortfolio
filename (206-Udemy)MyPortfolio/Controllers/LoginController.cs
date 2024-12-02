using _206_Udemy_MyPortfolio.DAL.Context;
using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.Controllers
{
    public class LoginController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            var _username = context.Admins.Select(x => x.UserName).ToString();
            var _password = context.Admins.Select(x => x.Password).ToString();

            if (admin.UserName == _username.ToString() && admin.Password == _password.ToString())
            {
                return RedirectToAction("Index", "About");
            }
            else
            {
                return View();
            }
        }
    }
}
