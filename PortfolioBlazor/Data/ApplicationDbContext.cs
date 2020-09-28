using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioBlazor.Models;

namespace PortfolioBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> PortfolioUsers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Honors> Honors { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Internship> Internships { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Activites> Activites { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Visitor> Visitors { get; set; }


    }
}
