using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
