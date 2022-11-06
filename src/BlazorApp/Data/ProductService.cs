namespace BlazorApp.Data;

public class ProductService
{

    public Task<Product[]> GetProductsAsync()
    {

        Product[] productList = {
            new Product() {Selected = false, Title = "Sign, 4X6", Description = "4x6 Sign displayed at Bolton Capital Field", Price = 400},
            new Product() {Selected = false, Title = "Team Sponsor", Description = "Display your company name on a team jersey", Price = 450},
            new Product() {Selected = false, Title = "Sign and Team Sponsor", Description = "4x6 Sign displayed at Bolton Capital Field and your name on a team jersey", Price = 750},
        };

        return Task.FromResult(productList);
    }
}
