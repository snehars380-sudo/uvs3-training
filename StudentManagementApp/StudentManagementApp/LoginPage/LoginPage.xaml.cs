using Microsoft.Maui.Controls;

namespace StudentManagementApp;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (username.Text == "admin" && password.Text == "1234")
        {
            await DisplayAlert("Success", "Login OK", "OK");
            await Navigation.PushAsync(new MarkListPage());
        }
        else
        {
            await DisplayAlert("Error", "Wrong login", "OK");
        }
    }
}