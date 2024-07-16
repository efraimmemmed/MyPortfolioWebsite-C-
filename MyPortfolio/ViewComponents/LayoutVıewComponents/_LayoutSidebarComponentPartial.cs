using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutVıewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
