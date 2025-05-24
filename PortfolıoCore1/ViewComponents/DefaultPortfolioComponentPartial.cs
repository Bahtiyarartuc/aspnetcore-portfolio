using Microsoft.AspNetCore.Mvc;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultPortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        
        }

    }
}
