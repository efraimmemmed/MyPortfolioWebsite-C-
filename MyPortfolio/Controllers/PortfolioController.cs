using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
      
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
 