using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models;


// This class represents a price quote with properties for:
// subtotal, discount percent, discount amount, and total.
public class PriceQuote
{
    // The subtotal is a value between 0 and 5000.
    [Required(ErrorMessage = "Please enter a value for the subtotal price.")]
    [Range(0, 5000, ErrorMessage = "The subtotal must be a number between 0 and 5000.")]
    public decimal Subtotal { get; set; }

    // The discount percent is a value between 0 and 100.
    [Required(ErrorMessage = "Please enter a value for the discount percentage.")]
    [Range(0, 100, ErrorMessage = "The discount percent must be between 0 and 100.")]
    public decimal DiscountPercent { get; set; }

    // The discount amount is calculated as a percentage of the subtotal.
    public decimal DiscountAmount => Subtotal * DiscountPercent / 100;
    // The total is the subtotal minus the discount amount.
    public decimal Total => Subtotal - DiscountAmount;

    // math is working now for discountamount calc

}