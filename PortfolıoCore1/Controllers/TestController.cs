using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.Controllers
{
    public class TestController : Controller
    {
        //[Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
