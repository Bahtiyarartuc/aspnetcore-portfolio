﻿namespace PortfolıoCore1.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
