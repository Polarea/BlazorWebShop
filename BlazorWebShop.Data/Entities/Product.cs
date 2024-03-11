using BlazorWebShop.Data.Interfaces;

namespace BlazorWebShop.Data.Entities
{
	public class Product : IProduct
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty ;
		public string ImageUrl { get; set; } = string.Empty;
		public int Price { get; set; }
	}
}
