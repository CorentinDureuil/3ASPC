using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class Login : PageModel
{
    [BindProperty]
    public LoginModel User { get; set; }
    
    private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

    public void OnGet()
    {
        
    }
    
    public void /*IActionResult*/ OnPostSubmit()
    {
        if (ModelState.IsValid)
        {
            ModelState.AddModelError("User.Email", "Model Valid");
            //return new RedirectToPageResult("/Portal/Login");
        }
        else
        {
            // Do errors
        }
    }
}