using BlazorWebShop.Data.Entities;
using BlazorWebShop.Data.Interfaces;
using Microsoft.AspNetCore.Http;

namespace BlazorWebShop.Data.SharedServices
{
	public class SharedService
	{
		private readonly IHttpContextAccessor _httpcontextAccessor;
		private readonly IBlazorWebShopRepository _repository;
		public SharedService(IHttpContextAccessor httpContextAccessor, IBlazorWebShopRepository repository)
		{
			_httpcontextAccessor = httpContextAccessor;
			_repository = repository;
		}

		private HttpContext? httpContext => _httpcontextAccessor.HttpContext;
		private string? sessionId = "";

		public List<Product>? Products { get; set; } = new();
		public ShoppingCart ShoppingCart { get; set; } = new();

		string? GetCookie()
		{
			var sessionId = httpContext?.Request.Cookies["sessionId"];
			return sessionId;
		}
		void AddCookie()
		{
			sessionId = Guid.NewGuid().ToString();
			var options = new CookieOptions
			{
				Expires = DateTime.UtcNow.AddMinutes(10),
				Secure = true,
				HttpOnly = true,
				IsEssential = true
			};
			httpContext?.Response.Cookies.Append("sessionId", sessionId, options);
		}

		async Task GetShoppingCartAsync()
		{
			ShoppingCart = await _repository.GetEntityAsync<ShoppingCart>(s => s.SessionId == sessionId);
		}

		public async Task GetShoppingCartAndProductsAsync()
		{
			sessionId = GetCookie();
			if (sessionId == null)
			{
				AddCookie();
			}
			await GetShoppingCartAsync();
			if (ShoppingCart == null)
			{
				ShoppingCart = new ShoppingCart() { SessionId = sessionId! };
				ShoppingCart.Id = await _repository.AddEntityAsync<ShoppingCart>(ShoppingCart);
			}
			Products = await _repository.GetEntitiesAsync<Product>() as List<Product>;
		}
	}
}
