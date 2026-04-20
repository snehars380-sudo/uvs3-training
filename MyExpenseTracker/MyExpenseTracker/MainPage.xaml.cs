using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace MyExpenseTracker;

public partial class MainPage : ContentPage
{
    private readonly List<Expense> expenses = new List<Expense>();
    private Entry titleEntry;
    private Entry amountEntry; // <-- changed from object to Entry
    private ListView expenseList;

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
    public string Title { get; set; } = string.Empty;
    public double Amount { get; set; }
}