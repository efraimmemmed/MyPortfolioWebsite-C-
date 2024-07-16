using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutVıewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); 
		}
	}
}
