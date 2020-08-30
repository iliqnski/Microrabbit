using MediatR;
using Microrabbit.Banking.Application.Interfaces;
using Microrabbit.Banking.Application.Services;
using Microrabbit.Banking.Data.Context;
using Microrabbit.Banking.Data.Repository;
using Microrabbit.Banking.Domain.CommandHandlers;
using Microrabbit.Banking.Domain.Commands;
using Microrabbit.Banking.Domain.Events;
using Microrabbit.Banking.Domain.Interfaces;
using Microrabbit.Domain.Core.Bus;
using Microrabbit.Infra.Bus;
using Microrabbit.Transfer.Application.Interfaces;
using Microrabbit.Transfer.Application.Services;
using Microrabbit.Transfer.Data.Context;
using Microrabbit.Transfer.Data.Repository;
using Microrabbit.Transfer.Domain.EventHandlers;
using Microrabbit.Transfer.Domain.Events;
using Microrabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Microrabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMqBus>(op => {
                var scopeFactory = op.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMqBus(op.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<TransferEventHandler>();

            //Domain Banking commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<Transfer.Domain.Events.TransferCreatedEvent>, TransferEventHandler>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
