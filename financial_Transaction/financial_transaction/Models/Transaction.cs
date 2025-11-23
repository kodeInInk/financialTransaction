namespace financial_transaction.Models;

public class Transaction
{
    Guid Id { get; set; }
    DateTime Date { get; set; }
    Guid CardId { get; set; }
    Guid ClientId { get; set; }
    Guid MerchantId { get; set; }
}