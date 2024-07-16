using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutVıewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); 
		}
	
	}
}
