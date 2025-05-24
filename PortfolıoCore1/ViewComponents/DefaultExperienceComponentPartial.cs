using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultExperienceComponentPartial : ViewComponent
    {
         PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = context.Experiences.ToList();
            return View(value);
        }
    }
}
