using Microsoft.AspNetCore.Identity;

namespace SchoolManagementApi.Models;

public class Student 
{
   
    public string? FName { get; set; }
    public string? LName { get; set; }
    public DateOnly DateOfBirth { get; set; } 
    public string? Email { get; set; }
    public string? PhoneNo { get; set; }
    public string? MatNo { get; set; }
    public int Level { get; set; }
    public DateOnly YearOfEntry { get; set; }
    public string? Dept { get; set; }
    public string? Faculty { get; set; }
    public string? School { get; set; }


}
