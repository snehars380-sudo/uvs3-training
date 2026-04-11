using Student_Management_App.ViewModels;

namespace Student_Management_App.Views;



public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();

		BindingContext = new StudentViewmodel();
    }
}