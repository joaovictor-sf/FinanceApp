using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models {
    public class Expense {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public double Amount { get; set; }// Using decimal for currency is a common practice to avoid floating-point precision issues. If size is a concern, you might consider using a smaller type like `float` or 'double', but it is generally not recommended for financial calculations.
        [Required]
        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
