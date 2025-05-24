using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultCategoryComponentPartial : ViewComponent
       
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        { 
         var values = context.Categories.ToList();
            return View(values);
        }
    }
}
