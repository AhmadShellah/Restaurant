using Domain;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
                     options.UseSqlServer(@"Data Source=DESKTOP-4V00ANF;Initial Catalog=Restaurent;Integrated Security=True;TrustServerCertificate=True");

        public DbSet<Drinks> Drinkss { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Cocktail> Cocktail { get; set; }

    }
}