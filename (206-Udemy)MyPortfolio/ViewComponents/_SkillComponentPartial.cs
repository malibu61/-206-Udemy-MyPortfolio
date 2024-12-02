using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
