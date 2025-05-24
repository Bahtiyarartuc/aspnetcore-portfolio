using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultTestmonialComponentPatial : ViewComponent
    {
        PortfolioContext Context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
         var values = Context.Testimonials.ToList();
            return View(values);


        }
    }
}
