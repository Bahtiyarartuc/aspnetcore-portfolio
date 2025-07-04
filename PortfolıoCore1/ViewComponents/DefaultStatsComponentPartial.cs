﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;

namespace PortfolıoCore1.ViewComponents
{
    public class DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v0 = context.Testimonials.Count();
            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = context.Skills.Count();
            Random rnd = new Random();
            int rndNumber = rnd.Next(10, 21);
            ViewBag.v3 = rndNumber;
            return View();
        }
    }
}
