using System.Collections.ObjectModel;
using StudentApp.Models;

namespace StudentApp.ViewModels;

public class StudentViewModel
{
    public ObservableCollection<Student> Students { get; set; }

    public StudentViewModel()
    {
        Students = new ObservableCollection<Student>
        {
            new Student { Name="Siva", Mark1=90, Mark2=85, Mark3=88 },
            new Student { Name="Ram", Mark1=70, Mark2=75, Mark3=80 },
            new Student { Name="Priya", Mark1=95, Mark2=92, Mark3=89 }
        };
    }
}