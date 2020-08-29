using Microrabbit.Banking.Application.Interfaces;
using Microrabbit.Banking.Domain.Interfaces;
using Microrabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
