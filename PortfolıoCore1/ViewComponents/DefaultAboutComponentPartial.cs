using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultAboutComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }
    }
}
