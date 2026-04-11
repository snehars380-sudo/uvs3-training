using Microsoft.Maui.Storage;
  namespace Student_Management_App.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }
    private async void OnRegisterUser(object sender, EventArgs e)
    {
       
        Preferences.Set("username", newUsername.Text);
        Preferences.Set("password", newPassword.Text);
        
        await DisplayAlert("Success", "User Registered", "OK");

        await Shell.Current.GoToAsync("..");
    }
}