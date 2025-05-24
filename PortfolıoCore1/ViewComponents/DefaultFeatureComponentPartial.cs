using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultFeatureComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Features.ToList();
          return View(value);
        }
    }
}
