using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;
using PortfolıoCore1.Entities;

namespace PortfolıoCore1.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.Success = "mesaj Gönderimi Başarılı";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
