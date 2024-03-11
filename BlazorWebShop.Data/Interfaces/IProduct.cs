namespace BlazorWebShop.Data.Interfaces
{
	public interface IProduct
	{
		int Id { get; set; }
		int Quantity { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		string ImageUrl { get; set; }
        int Price { get; set; }

	}
}
