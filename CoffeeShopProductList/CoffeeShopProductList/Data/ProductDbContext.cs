using CoffeeShopProductList.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopProductList.Data;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

}
