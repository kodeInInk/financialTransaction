using financial_transaction.Models;

namespace financial_transaction.Controllers;
using Microsoft.AspNetCore.Mvc;
using financial_transaction.Repositories;

public class MerchantController: ControllerBase
{
    private readonly ILogger<MerchantController> _logger;
    private readonly IMerchantRepository _merchantRepository;
    
    public MerchantController(ILogger<MerchantController> logger, IMerchantRepository merchantRepository)
    {
        _logger = logger;
        _merchantRepository = merchantRepository;
    }

    [HttpGet("{id}")]
    public Task<Merchant> Get(int id)
    {
        _merchantRepository.GetByIdAsync(id);
    }
    
    [HttpPost]
    public Task Add(Merchant merchant)
    {
        return _merchantRepository.AddAsync(merchant);
    }
}