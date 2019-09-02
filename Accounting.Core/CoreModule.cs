using Accounting.Core.Entities;
using Accounting.Core.Interfaces.UseCases;
using Accounting.Core.UseCases;
using Autofac;

namespace Accounting.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UseCase<Transaction, int>>().As<IUseCase<Transaction, int>>().InstancePerLifetimeScope();
            builder.RegisterType<UseCase<Account, int>>().As<IUseCase<Account, int>>().InstancePerLifetimeScope();
        }
    }
}
