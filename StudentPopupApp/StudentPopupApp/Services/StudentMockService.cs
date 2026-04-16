using System.Collections.ObjectModel;
using StudentPopupApp.Models;

namespace StudentPopupApp.Services;

public class StudentMockService : IStudentService
{
    private ObservableCollection<Student> _students = new();

    public ObservableCollection<Student> GetStudents()
    {
        return _students;
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void UpdateStudent(Student student)
    {
        // Auto updates because reference type
    }

    public void DeleteStudent(Student student)
    {
        _students.Remove(student);
    }
}