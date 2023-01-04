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
    private readonly Password _password = new Password();

    public void OnGet()
    {
        
    }
    
    public async Task<IActionResult> OnPostSubmit()
    {
        if (ModelState.IsValid)
        {
            UserModel? userWithMail = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == User.Email);
            
            if (userWithMail == null) ModelState.AddModelError("User.Email", "Email introuvable.");
            else
            {
                bool samePassword = _password.VerifyPassword(User.Password, userWithMail.Password, userWithMail.Salt);

                if (!samePassword) ModelState.AddModelError("User.Email", "Mot de passe incorrect.");
                else ModelState.AddModelError("User.Email", "User valide");
            }
        }

        return Page();
    }
}