using Accounting.Core.Entities;
using Accounting.Core.Interfaces.Repositories;
using Accounting.Core.Interfaces.UnitsOfWork;
using Accounting.Infrastructure.Repositories;
using Accounting.Infrastructure.UnitsOfWork;
using Autofac;

namespace Accounting.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Repository<Transaction, int>>().As<IRepository<Transaction, int>>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork<Transaction, int>>().As<IUnitOfWork<Transaction, int>>().InstancePerLifetimeScope();
            builder.RegisterType<Repository<Account, int>>().As<IRepository<Account, int>>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork<Account, int>>().As<IUnitOfWork<Account, int>>().InstancePerLifetimeScope();
        }
    }
}
