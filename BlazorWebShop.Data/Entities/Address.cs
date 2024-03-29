﻿using BlazorWebShop.Data.Interfaces;

namespace BlazorWebShop.Data.Entities
{
    public class Address : IAddress
	{
		public int Id { get; set; }
		public string StreetName { get; set; } = string.Empty;
		public int ResidenceNumber { get; set; }
        public string City { get; set; } = string.Empty;
        public int PostalCode { get; set; }
		public string Country { get; set; } = string.Empty;
	}
}
