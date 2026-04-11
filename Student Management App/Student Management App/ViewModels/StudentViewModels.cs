using System.Collections.ObjectModel;
using Student_Management_App.Models;

namespace Student_Management_App.ViewModels
{
    public class StudentViewmodel
    {
        public ObservableCollection<Student> Students { get; set; } 

        public StudentViewmodel()
        {
            Students = new ObservableCollection<Student>
            {
                new() { Name = "Alice", Age = 20, Grade = "A", Tamil = 85, English = 90, Math = 95 },
                new(){ Name = "Bob", Age = 22, Grade = "B", Tamil = 75, English = 80, Math = 85 },
                new(){ Name = "Charlie", Age = 21, Grade = "C", Tamil = 65, English = 70, Math = 75 }
            };
        }
    }
}