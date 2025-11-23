using Microsoft.VisualBasic.CompilerServices;

namespace financial_transaction.Models;

public class Card: BaseEntity
{
    decimal Amount { get; set; }
    string UseChip { get; set; }
}