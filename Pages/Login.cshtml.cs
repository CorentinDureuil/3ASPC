using FirstPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class Login : PageModel
{
    [BindProperty]
    public LoginModel User { get; set; }
    
    public void OnGet()
    {
        
    }
    
    public void OnPostSubmit()
    {
        if (ModelState.IsValid)
        {
            ModelState.AddModelError("User.Email", "Model Valid");
        }
        else
        {
            // Do errors
        }
    }
}