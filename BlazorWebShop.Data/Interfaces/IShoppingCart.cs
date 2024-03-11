using BlazorWebShop.Data.Entities;

namespace BlazorWebShop.Data.Interfaces
{
	public interface IShoppingCart
	{
		int Id { get; set; }
		string SessionId { get; set; }
		List<CartItem> CartItems { get; set; }
	}
}
