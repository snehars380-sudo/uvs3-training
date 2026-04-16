using System.Collections.ObjectModel;
using StudentPopupApp.Models;
using StudentPopupApp.Services;

namespace StudentPopupApp.ViewModels;

public class MainViewModel
{
    public ObservableCollection<Student> Students { get; set; }

    public MainViewModel(IStudentService service)
    {
        Students = service.GetStudents();
    }
}