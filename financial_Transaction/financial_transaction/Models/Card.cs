namespace financial_transaction.Models;

public class Card
{
    Guid Id { get; set; }
    decimal Amount { get; set; }
    string UseChip { get; set; }
}