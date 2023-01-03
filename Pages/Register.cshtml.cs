using FirstPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstPages;

public class Register : PageModel
{
    public string RegisterResult { get; set; }
 
    public void OnGet()
    {
    }
 
    public void OnPostSubmit(User user)
    {
        RegisterResult = string.Format($"Votre utilisateur: {user.Email}");
    }
}