using System.ComponentModel.DataAnnotations;

namespace FirstPages.Models;

public class RegisterModel
{
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    [Compare(nameof(Password), ErrorMessage = "Password and Confirmation Password must match.")]
    public string VerifyPassword { get; set; }
}