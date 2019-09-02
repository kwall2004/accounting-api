using Accounting.Api.Interfaces;
using Accounting.Api.Presenters;
using Accounting.Core.Entities;
using Autofac;

namespace Accounting.Core
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Presenter<Account>>().As<IPresenter<Account>>().SingleInstance();
        }
    }
}
