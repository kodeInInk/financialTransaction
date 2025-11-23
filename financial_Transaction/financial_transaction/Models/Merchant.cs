namespace financial_transaction.Models;

public class Merchant: BaseEntity
{   
    string City { get; set; }
    string? State { get; set; } //nullable
}