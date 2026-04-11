using Microsoft.Maui.Controls;
using MauiApp1.ViewModels;

namespace MauiApp1.Views
{
    public partial class StudentDetailsPage : ContentPage
    {
        public StudentDetailsPage()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}
