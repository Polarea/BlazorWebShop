using BlazorWebShop.Data.Interfaces;

namespace BlazorWebShop.Data.Entities
{
	public class CartItem : ICartItem
	{
		public int Id { get; set; }
		public Product Product { get; set; } = new Product();
		public int Quantity { get; set; }
	}
}
