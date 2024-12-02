using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
