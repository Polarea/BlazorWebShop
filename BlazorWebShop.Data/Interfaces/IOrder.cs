using BlazorWebShop.Data.Entities;

namespace BlazorWebShop.Data.Interfaces
{
	public interface IOrder
	{
		int Id { get; set; }
		int CustomerId { get; set; }
		List<CartItem> CartItems { get; set; }

	}
}
