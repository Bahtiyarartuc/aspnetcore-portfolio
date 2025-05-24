using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
         return View();
        
        }
    }
}
