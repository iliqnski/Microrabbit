using Microrabbit.Banking.Data.Context;
using Microrabbit.Banking.Domain.Interfaces;
using Microrabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
