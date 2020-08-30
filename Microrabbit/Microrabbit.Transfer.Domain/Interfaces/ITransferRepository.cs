using Microrabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
