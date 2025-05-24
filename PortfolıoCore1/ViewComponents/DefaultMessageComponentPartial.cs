using Microsoft.AspNetCore.Mvc;
using PortfolıoCore1.Entities;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultMessageComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View(new Message());
        }
    }
}
