﻿using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Service {
    public class ExpensesService : IExpensesService {
        private readonly FinanceAppContext _context;
        public ExpensesService(FinanceAppContext context) {
            _context = context;
        }

        public async Task AddExpenseAsync(Expense expense) {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
        }

        public Task DeleteExpenseAsync(int id) {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Expense>> GetAllExpensesAsync() {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }

        public Task<Expense> GetExpenseByIdAsync(int id) {
            throw new NotImplementedException();
        }

        public Task UpdateExpenseAsync(Expense expense) {
            throw new NotImplementedException();
        }
    }
}
