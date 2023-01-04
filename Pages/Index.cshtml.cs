using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FirstPages;

public class Index : PageModel
{
    public string Message { get; set; }
    public DbSet<Product> Products { get; set; }
    
    private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

    public void OnGet()
    {
        Products = _dbContext.Products;
        Message = $"Nombre de produits: {Products.Count()}";
    }
}