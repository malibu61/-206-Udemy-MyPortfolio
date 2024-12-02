using _206_Udemy_MyPortfolio.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace _206_Udemy_MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MUHAMMETALI45\\SQLEXPRESS;initial catalog=(206-Udemy)MyPortfolioDb;integrated security=true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
