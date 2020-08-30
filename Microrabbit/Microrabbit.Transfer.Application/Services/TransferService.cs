using Microrabbit.Transfer.Application.Interfaces;
using Microrabbit.Transfer.Domain.Interfaces;
using Microrabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using Microrabbit.Transfer.Domain.Models;

namespace Microrabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository,
            IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
