using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultContactComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
    }
}
