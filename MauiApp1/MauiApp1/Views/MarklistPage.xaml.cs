using Microsoft.Maui.Controls;
using MauiApp1.ViewModels;

namespace MauiApp1.Views
{
    public partial class MarklistPage : ContentPage
    {
        public MarklistPage()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}
