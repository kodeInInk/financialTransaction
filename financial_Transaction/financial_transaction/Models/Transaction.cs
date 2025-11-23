namespace financial_transaction.Models;

public class Transaction: BaseEntity
{
    DateTime Date { get; set; }
    int CardId { get; set; }
    int ClientId { get; set; }
    int MerchantId { get; set; }
}