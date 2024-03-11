using BlazorWebShop.Data.Interfaces;

namespace BlazorWebShop.Data.Entities
{
	public class Order : IOrder
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public List<CartItem> CartItems { get; set; } = new List<CartItem>();
	}
}
