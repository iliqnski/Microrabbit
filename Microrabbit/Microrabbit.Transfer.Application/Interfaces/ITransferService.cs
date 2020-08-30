using Microrabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
