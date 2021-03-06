﻿using Microrabbit.Banking.Application.Models;
using Microrabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
