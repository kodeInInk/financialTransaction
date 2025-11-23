namespace financial_transaction.Models;

public class Merchant
{   
    Guid Id { get; set; }
    string City { get; set; }
    string? State { get; set; } //nullable
}