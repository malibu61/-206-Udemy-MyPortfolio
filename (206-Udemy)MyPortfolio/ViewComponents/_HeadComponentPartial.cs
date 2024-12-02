using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
