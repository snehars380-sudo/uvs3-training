using SmartSpendApp1.Models;

namespace SmartSpendApp1.Services;

public class DatabaseService
{
    private static List<Expense> data = new();

    public Task Init() => Task.CompletedTask;

    public Task<List<Expense>> GetExpenses()
    {
        return Task.FromResult(data);
    }

    public Task AddExpense(Expense e)
    {
        e.Id = data.Count + 1;
        data.Add(e);
        return Task.CompletedTask;
    }

    public Task DeleteExpense(Expense e)
    {
        data.Remove(e);
        return Task.CompletedTask;
    }
}