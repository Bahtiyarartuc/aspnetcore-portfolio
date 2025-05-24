using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.Controllers
{
    public class AdminlayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        public PartialViewResult partialHead()
        { 
          return PartialView();
          
        }
        public PartialViewResult PartialSidebar()
        {

            return PartialView();
        
        }
        public PartialViewResult PartialScript()
        { 
           return PartialView();
        
        }
    }
}
