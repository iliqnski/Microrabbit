using MediatR;
using Microrabbit.Banking.Application.Interfaces;
using Microrabbit.Banking.Application.Services;
using Microrabbit.Banking.Data.Context;
using Microrabbit.Banking.Data.Repository;
using Microrabbit.Banking.Domain.Interfaces;
using Microrabbit.Domain.Core.Bus;
using Microrabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microrabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMqBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
