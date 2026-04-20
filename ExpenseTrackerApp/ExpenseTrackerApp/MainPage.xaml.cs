namespace ExpenseTrackerApp;

public partial class MainPage : ContentPage
{
    List<Expense> expenses = new();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        double.TryParse(amountEntry.Text, out double amount);

        expenses.Add(new Expense
        {
            Title = titleEntry.Text,
            Amount = amount
        });

        expenseList.ItemsSource = null;
        expenseList.ItemsSource = expenses;

        titleEntry.Text = "";
        amountEntry.Text = "";
    }
}

public class Expense
{
    public string Title { get; set; }
    public double Amount { get; set; }
}