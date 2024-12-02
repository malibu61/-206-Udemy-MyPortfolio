using _206_Udemy_MyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace _206_Udemy_MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.SocialMedias.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
			ViewBag.v5 = context.Skills.Count();
			ViewBag.v6 = context.Skills.OrderByDescending(x => x.Value).Select(x => x.Title).FirstOrDefault().ToString();
			ViewBag.v7 = context.Experiences.Count();
			ViewBag.v8 = context.ToDoLists.Where(x => x.Status == false).Count();
			return View();
		}
	}
}
