using BlazorWebShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebShop.DbContexts
{
	public class BlazorWebShopContext(DbContextOptions<BlazorWebShopContext> options) : DbContext(options)
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ShoppingCart> ShoppingCarts { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
