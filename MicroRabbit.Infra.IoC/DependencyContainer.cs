using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service, IConfiguration configuration)
        {
            //Domain Bus
            service.AddTransient<IEventBus, RabbitMQBus>();
            service.Configure<RabbitMQSettings>(c => configuration.GetSection("RabbitMQSettings"));

            //Application Services
            service.AddTransient<IAccountService, AccountService>();

            //Data
            service.AddTransient<IAccountRepository, AccountRepositoty>();

            service.AddTransient<BankingDbContext>();

        }
    }
}
