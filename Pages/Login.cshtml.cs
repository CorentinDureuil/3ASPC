using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FirstPages;

public class Login : PageModel
{
    [BindProperty]
    public LoginModel User { get; set; }
    
    public UserModel UserLogged { get; set; }
    
    private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

    public void OnGet()
    {
        
    }
    
    public async Task<IActionResult> OnPostSubmit()
    {
        if (ModelState.IsValid)
        {
            UserLogged = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == User.Email && u.Password == User.Password);
            
            if (UserLogged == null)
            {
                ModelState.AddModelError("User.Email", "Email ou mot de passe incorrect");
            }
            
            ModelState.AddModelError("User.Email", "User valide");
        }

        return Page();
    }
}