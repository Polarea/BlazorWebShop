using BlazorWebShop.Data.Entities;

namespace BlazorWebShop.Data.Interfaces
{
	public interface ICustomer
	{
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string Password { get; set; }
		Address Address { get; set; }

	}
}
