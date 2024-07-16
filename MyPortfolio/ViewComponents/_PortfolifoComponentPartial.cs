using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolifoComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
