using SmartSpendApp1.Models;
using SmartSpendApp1.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace SmartSpendApp1;

public partial class ExpensesPage : ContentPage
{
    DatabaseService db = new();
    ObservableCollection<Expense> list = new();

    public ExpensesPage()
    {
        InitializeComponent();
        expenseList.ItemsSource = list;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Load();
    }

    async Task Load()
    {
        await db.Init();
        var data = await db.GetExpenses();

        list.Clear();
        foreach (var x in data)
            list.Add(x);

        TotalLabel.Text = "Total: ₹" + list.Sum(x => x.Amount);
    }

    private async void GoAdd(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpensePage());
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        var item = btn.BindingContext as Expense;

        await db.DeleteExpense(item);
        await Load();
    }
}