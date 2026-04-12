using SampleProject.MVVM.ViewModels;

namespace SampleProject.MVVM.Views;

public partial class Studentregistrationview : ContentPage
{
	public Studentregistrationview()
	{
        InitializeComponent();
        BindingContext = new StudentRegistrationviewmodel();
    }
}