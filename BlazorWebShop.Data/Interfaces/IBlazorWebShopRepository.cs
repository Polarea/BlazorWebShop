﻿using BlazorWebShop.Data.Entities;
using System.Linq.Expressions;

namespace BlazorWebShop.Data.Interfaces
{
	public interface IBlazorWebShopRepository
	{
		Task AddToCartAsync(int productId, int cartId, int quantity);
		Task AddToProduct(string url, int productId);
		Task<int> AddEntityAsync<T>(T entity) where T : class;
		Task<bool> DeletEntityAsync<T>(T entity) where T : class;
		Task<Order> GetOrderAsync(int orderId);
		Customer? GetCustomer(int customerId);
		Task<T> GetEntityAsync<T>(Expression<Func<T, bool>> expression) where T : class;
		Task<IEnumerable<T>> GetEntitiesAsync<T>() where T : class;
		Task<IEnumerable<T>> GetEntitiesByPropertyAsync<T>(Expression<Func<T, bool>> expression) where T : class;
		Task<bool> SaveChangesAsync();
		void Dispose();
	}
}
