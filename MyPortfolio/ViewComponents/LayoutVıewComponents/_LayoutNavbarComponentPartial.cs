using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutVıewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); 
		}
	}
}
