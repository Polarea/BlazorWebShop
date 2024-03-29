﻿using BlazorWebShop.Data.Interfaces;

namespace BlazorWebShop.Data.Entities
{
	public class Customer : ICustomer
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty ;
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; }= string.Empty;
		public Address Address { get; set; } = new Address();
	}
}
