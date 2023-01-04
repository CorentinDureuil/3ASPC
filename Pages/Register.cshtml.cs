using FirstPages.Data;
using FirstPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class Register : PageModel
{
    [BindProperty]
    public UserModel User { get; set; }

    private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();
    private readonly Password _password = new Password();
    
    public void OnGet()
    {
    }
 
    public void OnPostSubmit()
    {

        if (ModelState.IsValid)
        {
            User.Password = _password.HashPasword(User.Password, out var salt);
            User.Salt = salt;
            
            _dbContext.Users.Add(User);
            _dbContext.SaveChanges();
            
            ModelState.AddModelError("User.Email", "Model Valid");
        }
        else
        {
            // Do errors
        }
    }
}