using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultSocialMediaComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }
    }
}
