using BlazorWebShop.Data.Entities;

namespace BlazorWebShop.Data.Interfaces
{
	public interface ICartItem
	{
		int Id { get; }
		Product Product { get; set; }
		int Quantity { get; set; }
	}
}
