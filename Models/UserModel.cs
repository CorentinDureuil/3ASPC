using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstPages.Models;

public class UserModel
{
    [Key]
    public int Id { get; set; }
    
    [Column("email")]
    [Required]
    public string Email { get; set; }
    
    [Column("password")]
    [Required]
    public string Password { get; set; }
    
    [NotMapped]
    [Compare(nameof(Password), ErrorMessage = "Password and Confirmation Password must match.")]
    public string VerifyPassword { get; set; }

    [Column("salt")]
    public byte[]? Salt { get; set; }
}