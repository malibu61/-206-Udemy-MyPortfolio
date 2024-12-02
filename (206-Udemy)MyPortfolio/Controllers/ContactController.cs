using _206_Udemy_MyPortfolio.DAL.Context;
using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Contacts.FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            var values = context.Contacts.Find(contact.ContactId);
            values.Title = contact.Title;
            values.Description = contact.Description;
            values.Phone1 = contact.Phone1;
            values.Phone2 = contact.Phone2;
            values.Email1 = contact.Email1;
            values.Email2 = contact.Email2;
            values.Address = contact.Address;
            context.SaveChanges();
            return View();
        }


    }
}
