namespace Domain.Models;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Course { get; set; }
}
