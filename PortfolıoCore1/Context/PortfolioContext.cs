using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using PortfolıoCore1.Entities;

namespace PortfolioCore1.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2VT4JLT;initial Catalog=PortfolioNightDb;Integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Feature> Features { get; set; }


    }
}
