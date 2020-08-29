using Microrabbit.Banking.Application.Interfaces;
using Microrabbit.Banking.Application.Models;
using Microrabbit.Banking.Domain.Commands;
using Microrabbit.Banking.Domain.Interfaces;
using Microrabbit.Banking.Domain.Models;
using Microrabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository,
            IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
