using _206_Udemy_MyPortfolio.DAL.Context;
using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }

        public IViewComponentResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            portfolioContext.Messages.Add(message);
            portfolioContext.SaveChanges();
            return View();
        }
    }
}
