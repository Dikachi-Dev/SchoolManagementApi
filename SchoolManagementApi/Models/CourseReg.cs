namespace SchoolManagementApi.Models;

public class CourseReg
{
    public int Id { get; set; }
    public string? CourseCode { get; set; }
    public string? Title { get; set; }
    public string? Email { get; set; }
    public string? MatricNo { get; set; }
    public DateOnly YearOfStudy { get; set; }
    public int NumberOfTakes { get; set; }
    public int Semester { get; set; }
    public string? Status { get; set; }
    public string? Dept { get; set; }
    public string? Faculty { get; set; }
    public string? School { get; set; }
}
