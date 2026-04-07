using System.ComponentModel.Design;

namespace loginpage1;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (username == "admin" && password == "1234")
        {
            await DisplayAlert("Success", "Login Sucessful", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Invalid Login", "OK");
        }

    }
}