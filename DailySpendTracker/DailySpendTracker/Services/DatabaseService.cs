using SQLite;
using DailySpendTracker.Models;

namespace DailySpendTracker.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _db;

        public async Task Init()
        {
            if (_db != null) return;

            var path = Path.Combine(FileSystem.AppDataDirectory, "expense.db");

            _db = new SQLiteAsyncConnection(path);

            await _db.CreateTableAsync<Expense>();
        }

        public async Task<List<Expense>> GetExpenses()
        {
            await Init();
            return await _db.Table<Expense>().ToListAsync();
        }

        public async Task AddExpense(Expense expense)
        {
            await Init();
            await _db.InsertAsync(expense);
        }

        public async Task DeleteExpense(Expense expense)
        {
            await Init();
            await _db.DeleteAsync(expense);
        }
    }
}