using System.ComponentModel.DataAnnotations;
using SMS.Data.Entities;

namespace SMS.Web.Models;
    
public class UserViewModel
{       
    // TBC add attributes
    [Required]
    public string Name { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords don't match!")]
    [Display(Name = "Confirm Password")]
    public string PasswordConfirm { get; set; }
    

    [Required]
    public Role Role { get; set;}

}
