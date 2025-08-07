namespace FinanceApp.Models {
    public class Expense {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }// Using decimal for currency is a common practice to avoid floating-point precision issues. If size is a concern, you might consider using a smaller type like `float` or 'double', but it is generally not recommended for financial calculations.
        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
