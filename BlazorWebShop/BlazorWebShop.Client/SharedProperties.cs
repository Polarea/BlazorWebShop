using BlazorWebShop.Data.Entities;

namespace BlazorWebShop.Client
{
    public class SharedProperties
    {
        public List<Product> Products { get; set; } = [];
        public int ShoppingCartId { get; set; }

        public void UpdateClientSideProducts(List<Product> products, int id)
        {
            Products = products;
            ShoppingCartId = id;
        }
    }
}
