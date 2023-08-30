using Microsoft.AspNetCore.Mvc;

namespace Marketing.Controllers
{
    public class MarketingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
