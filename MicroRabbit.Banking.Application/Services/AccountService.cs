using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepositoty;

        public AccountService(IAccountRepository accountRepositoty)
        {
            _accountRepositoty = accountRepositoty;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepositoty.GetAccounts();
        }
    }
}
