using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext context = new MyPortfolioContext();
            var values = context.Projects.OrderByDescending(x => x.ProjectId).Take(8).ToList();
            return View(values);

        }
    }
}
