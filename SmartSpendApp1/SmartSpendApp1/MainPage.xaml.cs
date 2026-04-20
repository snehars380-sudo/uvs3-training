using SmartSpendApp1.Models;
using SmartSpendApp1.Services;
using SmartSpendApp1.Views;

namespace SmartSpendApp1;

public partial class MainPage : ContentPage
{
    DatabaseService db = new DatabaseService();

    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        expenseList.ItemsSource = await db.GetExpenses();
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpensePage());
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        var expense = btn.BindingContext as Expense;

        await db.DeleteExpense(expense);

        expenseList.ItemsSource = await db.GetExpenses();
    }
}