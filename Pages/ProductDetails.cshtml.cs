using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class ProductDetails : PageModel
{
    public string Message { get; set; }
    public Product FoundProduct;

    public void OnGet(int id)
    {
        Message = $"Article {id}";
        FoundProduct = ProductData.Products.FirstOrDefault(product => product.Id == id);
    }
}