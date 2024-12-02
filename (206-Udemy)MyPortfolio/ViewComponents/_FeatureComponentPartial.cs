using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            ViewBag.v1= context.Features.Select(x=>x.Title).FirstOrDefault();
            ViewBag.v2= context.Features.Select(x=>x.Description).FirstOrDefault();
            return View(values);
        }
    }
}
