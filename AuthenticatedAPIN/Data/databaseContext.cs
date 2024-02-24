using Microsoft.EntityFrameworkCore;
using AuthLibrary;

namespace AuthenticatedAPIN.Data;

public class databaseContext : DbContext
{
    public databaseContext(DbContextOptions<databaseContext> options) : base(options)
    { }

    public DbSet<ItemModel> Items { get; set; }
    public DbSet<CategoryModel> itemCategory { get; set; }
    public DbSet<ShoppingCart> ShoppingCart{get;set;}
}