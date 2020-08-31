using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microrabbit.MVC.Models;
using Microrabbit.MVC.Services;
using Microrabbit.MVC.Models.DTO;

namespace Microrabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransferService _transferService;
        public HomeController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel model)
        {
            TransferDto transferDto = new TransferDto
            {
                FromAccount = model.FromAccount,
                ToAccount = model.ToAccount,
                TransferAmount = model.TransferAmount
            };

            await _transferService.Transfer(transferDto);

            return View("Index");
        }
    }
}
