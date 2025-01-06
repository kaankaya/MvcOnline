using Microsoft.AspNetCore.Mvc;

namespace MvcOnline.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
