using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
