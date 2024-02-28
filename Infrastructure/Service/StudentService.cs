namespace Infrastructure.Service;
using Domain.Models;

public class StudentService
{
    List<Student> _students = new List<Student>();
    public List<Student> GetAll()
    {
        return _students;
    }
    public List<Student> GetById(Student student)
    {
      return _students.FindAll(p=>p.Id==student.Id);
    }
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
    public void UpdateStudents(Student student)
    {
        var upst=_students.FirstOrDefault(p=>p.Id==student.Id);
        upst.FirstName=student.FirstName;
        upst.LastName=student.LastName;
        upst.PhoneNumber=student.PhoneNumber;
        upst.BirthDate=student.BirthDate;
        upst.Course=student.Course;
    }
    public void DeleteStudents(Student student)
    {
        _students.Remove(student);
    }
}
