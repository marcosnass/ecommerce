using Microsoft.EntityFrameworkCore;
using ecommerce.Models;

namespace ecommerce.Contexts;

public class ecommerceContext : DbContext{

    public DbSet<Product> Products => Set<Product>();
    //caso ter outra classe de modelo é necessário criar outro DBSet

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=products.sqlite3");
        //optionsBuilder.UseSqlite("Data Source=products.sqlite3");
    }

}