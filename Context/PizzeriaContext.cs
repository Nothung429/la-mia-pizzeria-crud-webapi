using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class PizzeriaContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Pizza>? Pizza { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<Ingredient>? Ingredient { get; set; }
    public DbSet<Message>? Message { get; set; }

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
}