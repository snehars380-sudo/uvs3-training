using SmartSpendApp1.Models;
using SmartSpendApp1.Services;

namespace SmartSpendApp1;

public partial class AddExpensePage : ContentPage
{
    private readonly DatabaseService db = new();

    public AddExpensePage()
    {
        InitializeComponent();
    }

    private async void OnSave(object sender, EventArgs e)
    {
        await db.Init();

        if (string.IsNullOrWhiteSpace(titleEntry.Text) ||
            string.IsNullOrWhiteSpace(categoryEntry.Text) ||
            string.IsNullOrWhiteSpace(amountEntry.Text))
        {
            await DisplayAlert("Error", "Fill all fields", "OK");
            return;
        }

        if (!double.TryParse(amountEntry.Text, out double amt))
        {
            await DisplayAlert("Error", "Invalid amount", "OK");
            return;
        }

        var expense = new Expense
        {
            Title = titleEntry.Text,
            Category = c.Text,
            Amount = amt
        };

        await db.AddExpense(expense);

        await Navigation.PopAsync();
    }
}