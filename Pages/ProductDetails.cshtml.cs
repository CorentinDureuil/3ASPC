using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FirstPages;

public class ProductDetails : PageModel
{
    public Product FoundProduct;
    
    private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        FoundProduct = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

        if (FoundProduct == null)
        {
            return NotFound();
        }

        return Page();
    }
}