using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementApi.Models;

public class Register : IdentityUser
{
    [Required]
    public override string Email { get; set; } = default!;
    
}
