using BlazorWebShop.Data.Interfaces;

namespace BlazorWebShop.Data.Entities
{
	public class ShoppingCart : IShoppingCart
	{
		public int Id { get; set; }
		public string? SessionId { get; set; }
		public List<CartItem> CartItems { get; set; } = new List<CartItem>();

	}
}
