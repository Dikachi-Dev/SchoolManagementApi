namespace SchoolManagementApi.Models;

public class CourseReg
{
    public int Id { get; set; }
    public string CourseCode { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string MatricNo { get; set; } = default!;
    public DateOnly YearOfStudy { get; set; }
    public int NumberOfTakes { get; set; }
    public int Semester { get; set; }
    public string Status { get; set; } = default!;
    public string Dept { get; set; } = default!;
    public string Faculty { get; set; } = default!;
    public string School { get; set; } = default!;
}
