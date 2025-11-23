using financial_transaction.Data;
using financial_transaction.Models;
using Microsoft.EntityFrameworkCore;

namespace financial_transaction.Repositories;

public class MerchantRepository: IMerchantRepository
{
    public readonly FinancialTransactionDbContext _context;

    public MerchantRepository(FinancialTransactionDbContext context)
    {
        _context = context;
    }
    public async Task<Merchant?> GetByIdAsync(int id)
    {
        //TODO: create merchant table in database
        return await _context.Set<Merchant>()
            .FirstOrDefaultAsync<Merchant>(m => m.Id.Equals(id));
    }

    public async Task<IEnumerable<Merchant>> GetAllAsync()
    {
        return await _context.Set<Merchant>()
            .ToArrayAsync<Merchant>();
    }

    public Task AddAsync(Merchant merchant)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Merchant merchant)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}

public interface IMerchantRepository
{
    Task<Merchant?> GetByIdAsync(int id); // R -read
    Task<IEnumerable<Merchant>> GetAllAsync(); // R
    Task AddAsync(Merchant merchant); // C - create / P - post
    Task UpdateAsync(Merchant merchant); // U - update
    Task DeleteAsync(Guid id); // D - delete
}