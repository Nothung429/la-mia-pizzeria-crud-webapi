using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class PizzeriaContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Pizza>? Pizza { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<Ingredient>? Ingredient { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-Restaurant;Integrated Security=True;Pooling=False");
    }

    public PizzeriaContext()
    {

    }

    public PizzeriaContext(DbContextOptions<PizzeriaContext> options)
    : base(options)
    {

    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Ingredient>().HasData
    //    (
    //        new Ingredient
    //        {
    //            Id = 1,
    //            Name = "Pomodoro"
    //        },
    //        new Ingredient
    //        {
    //            Id = 2,
    //            Name = "Mozzerella"
    //        },
    //        new Ingredient
    //        {
    //            Id = 3,
    //            Name = "Olive"
    //        },
    //        new Ingredient
    //        {
    //            Id = 4,
    //            Name = "Scamorza"
    //        },
    //        new Ingredient
    //        {
    //            Id = 5,
    //            Name = "Prosciutto"
    //        },
    //        new Ingredient
    //        {
    //            Id = 6,
    //            Name = "Tonno"
    //        }
    //    );

    //    modelBuilder.Entity<Category>().HasData
    //    (
    //        new Category
    //        {
    //            Id = 1,
    //            Name = "Pizza Bianca"
    //        },
    //        new Category
    //        {
    //            Id = 2,
    //            Name = "Pizza Rossa"
    //        },
    //        new Category
    //        {
    //            Id = 3,
    //            Name = "Pizza Vegana"
    //        },
    //        new Category
    //        {
    //            Id = 4,
    //            Name = "Pizza Senza Glutine"
    //        }
    //    );
    //}
}