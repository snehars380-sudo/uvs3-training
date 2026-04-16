using System.Collections.ObjectModel;
using StudentPopupApp.Models;

namespace StudentPopupApp.Views;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Student> Students { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Students = new ObservableCollection<Student>()
        {
            new Student { Name = "Siva", RegNo = "23CS101", Mark = 85 },
            new Student { Name = "Arun", RegNo = "23CS102", Mark = 90 }
        };

        BindingContext = this;
    }

    // ✅ ADD
    private async void OnAddClicked(object sender, EventArgs e)
    {
        string name = await DisplayPromptAsync("Add Student", "Enter Name:");
        string regno = await DisplayPromptAsync("Add Student", "Enter Reg No:");
        string markText = await DisplayPromptAsync("Add Student", "Enter Mark:");

        if (!string.IsNullOrWhiteSpace(name) &&
            !string.IsNullOrWhiteSpace(regno) &&
            int.TryParse(markText, out int mark))
        {
            Students.Add(new Student
            {
                Name = name,
                RegNo = regno,
                Mark = mark
            });
        }
    }

    // ✅ EDIT
    private async void OnEditClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var student = button?.BindingContext as Student;

        if (student != null)
        {
            string name = await DisplayPromptAsync("Edit", "Edit Name:", initialValue: student.Name);
            string regno = await DisplayPromptAsync("Edit", "Edit Reg No:", initialValue: student.RegNo);
            string markText = await DisplayPromptAsync("Edit", "Edit Mark:", initialValue: student.Mark.ToString());

            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(regno) &&
                int.TryParse(markText, out int mark))
            {
                student.Name = name;
                student.RegNo = regno;
                student.Mark = mark;

                // Refresh UI
                BindingContext = null;
                BindingContext = this;
            }
        }
    }

    // ✅ DELETE
    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var student = button?.BindingContext as Student;

        if (student != null)
        {
            bool confirm = await DisplayAlert("Delete", $"Delete {student.Name}?", "Yes", "No");

            if (confirm)
            {
                Students.Remove(student);
            }
        }
    }
}