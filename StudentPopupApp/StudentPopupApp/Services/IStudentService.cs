using System.Collections.ObjectModel;
using StudentPopupApp.Models;

namespace StudentPopupApp.Services;

public interface IStudentService
{
    ObservableCollection<Student> GetStudents();
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(Student student);
}