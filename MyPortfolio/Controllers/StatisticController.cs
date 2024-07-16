using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context;
		public IActionResult Index()
		{
			return View();
		}
	}
}
