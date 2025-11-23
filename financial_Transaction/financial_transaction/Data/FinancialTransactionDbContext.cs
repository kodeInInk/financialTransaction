using Microsoft.EntityFrameworkCore;

namespace financial_transaction.Data;

public class FinancialTransactionDbContext: DbContext
{
    public FinancialTransactionDbContext(DbContextOptions<FinancialTransactionDbContext> options) : base(options)
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Card> Cards { get; set; } = null!;
        public DbSet<Merchant> Merchants { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        // waiting to create and spin up a docker image
    }
}