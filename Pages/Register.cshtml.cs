using FirstPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class Register : PageModel
{
    [BindProperty]
    public RegisterModel User { get; set; }
    
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