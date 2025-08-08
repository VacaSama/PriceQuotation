namespace PriceQuotation.Models;


// This class represents a price quote with properties for:
// subtotal, discount percent, discount amount, and total.
public class PriceQuote
{
    public decimal Subtotal { get; set; }
    public decimal DiscountPercent { get; set; }
    public decimal DiscountAmount { get; set; } = 0;
    public decimal Total { get; set; }

    // Constructor to initialize properties
    public PriceQuote() {
        Subtotal = 0;
        DiscountPercent = 0;
        DiscountAmount = 0;
        Total = 0;
    }
}