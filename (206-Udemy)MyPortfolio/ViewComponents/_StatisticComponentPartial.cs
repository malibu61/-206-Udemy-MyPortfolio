using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.certificates = 10;
            ViewBag.cupsOfCoffes = 437;
            ViewBag.projects = 36;
            ViewBag.skills = context.Skills.Count();
            return View();
        }
    }
}
