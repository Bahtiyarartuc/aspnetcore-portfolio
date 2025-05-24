using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
