using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepositoty : IAccountRepository
    {
        private readonly BankingDbContext _context;

        public AccountRepositoty(BankingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
           
            return _context.Accounts;
        }
    }
}
