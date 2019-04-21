using Autofac;
using Autofac.Engine;
using Microsoft.EntityFrameworkCore.Engine;
using Surf.Services.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surf.Http.Framework.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 0;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            var connectionString = "";
            builder.Register<IDbContext>(e => new EfeObjectContext(connectionString)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EfeRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>().InstancePerDependency();

        }
    }
}
