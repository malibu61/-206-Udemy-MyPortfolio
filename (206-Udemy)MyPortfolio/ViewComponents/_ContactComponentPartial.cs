using _206_Udemy_MyPortfolio.DAL.Context;
using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            return View();
        }




    }
}
