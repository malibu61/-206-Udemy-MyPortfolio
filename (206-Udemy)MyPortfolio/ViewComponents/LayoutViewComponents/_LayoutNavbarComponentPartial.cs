using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            ViewBag.v1 = context.Profiles.Where(x => x.ProfileId == 1).Select(x => x.Name).FirstOrDefault();
            ViewBag.v2 = context.Profiles.Where(x => x.ProfileId == 1).Select(x => x.Surname).FirstOrDefault();
            ViewBag.v3 = context.Profiles.Where(x => x.ProfileId == 1).Select(x => x.ImageUrl).FirstOrDefault();
            return View(values);
        }
    }
}
