using _206_Udemy_MyPortfolio.DAL.Context;
using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.Controllers
{
    public class ContactSendMessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }

    }
}
