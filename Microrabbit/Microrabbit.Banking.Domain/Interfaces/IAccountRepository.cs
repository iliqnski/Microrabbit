using Microrabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
