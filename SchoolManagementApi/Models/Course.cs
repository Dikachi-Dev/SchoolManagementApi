namespace SchoolManagementApi.Models;

public class Course
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Code { get; set; }
    public int CreditUnit { get; set; }
    public int NumberStudent { get; set; }
    //public DateOnly YearOfStudy { get; set; }//add to course reg model
    public int Semester { get; set; }
    public string? Lecturer { get; set; }
    public string? Description { get; set; }


}
