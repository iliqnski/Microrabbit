using Microrabbit.MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microrabbit.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
