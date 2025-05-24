using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
          return View(); 
        }
    }
}
