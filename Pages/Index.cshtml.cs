using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class Index : PageModel
{
    public string Message { get; set; }
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        Products = ProductData.Products;
        Message = $"Nombre de produits: {ProductData.Products.Count}";
    }
}