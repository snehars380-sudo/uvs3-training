using DailySpendTracker.Models;
using DailySpendTracker.Services;

namespace DailySpendTracker;

public partial class MainPage : ContentPage
{
    private readonly DatabaseService _db;

    public MainPage(DatabaseService db)
    {
        InitializeComponent();
        _db = db;

        LoadData();
    }

    private async void LoadData()
    {
        var list = await _db.GetExpenses();
        expenseList.ItemsSource = list;

        double total = list.Sum(x => x.Amount);
        totalLabel.Text = $"Total: {total}";
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleEntry.Text) ||
            string.IsNullOrWhiteSpace(amountEntry.Text))
            return;

        var expense = new Expense
        {
            Title = titleEntry.Text,
            Amount = double.Parse(amountEntry.Text),
            Date = DateTime.Now
        };

        await _db.AddExpense(expense);

        titleEntry.Text = "";
        amountEntry.Text = "";

        LoadData();
    }

    private async void OnDeleteSwipe(object sender, EventArgs e)
    {
        var item = (sender as SwipeItem).BindingContext as Expense;

        if (item != null)
        {
            await _db.DeleteExpense(item);
            LoadData();
        }
    }
}