using _206_Udemy_MyPortfolio.DAL.Context;
using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Abouts.FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            var values = context.Abouts.Find(about.AboutId);
            values.Title = about.Title;
            values.SubDescription = about.SubDescription;
            values.Details = about.Details;
            context.SaveChanges();
            return View();
        }
    }
}
