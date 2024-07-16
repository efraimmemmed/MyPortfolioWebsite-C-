using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entites;

namespace MyPortfolio.Controllers
{
	public class FeatureController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult FeatureList()
		{
			var values = context.Feature.ToList();
			return View(values);
		}

		[HttpGet]

		public IActionResult UpdateFeature(int id)
		{
			var value =context.Feature.Find(id);
			return View(value);
		}

	
		[HttpPost]
		public IActionResult UpdateFeature(Feature feature)
		{
         context.Feature.Update(feature);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
	}
}
