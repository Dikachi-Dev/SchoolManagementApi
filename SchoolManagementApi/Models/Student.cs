using Microsoft.AspNetCore.Identity;

namespace SchoolManagementApi.Models;

public class Student 
{
   
    public string FName { get; set; } = default!;
    public string LName { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; } 
    public string Email { get; set; } = default!;
    public string PhoneNo { get; set; } = default!;
    public string MatNo { get; set; } = default!;
    public int Level { get; set; }
    public DateOnly YearOfEntry { get; set; }
    public string Dept { get; set; } = default!;
    public string Faculty { get; set; } = default!;
    public string School { get; set; } = default!;


}
