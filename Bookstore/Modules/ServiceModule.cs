﻿using System;
using System.Reflection;
using Autofac;

namespace Bookstore.Modules
{
    public class ServiceModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("Bookstore"))
                   .Where(t => t.Name.EndsWith("Service", StringComparison.CurrentCulture))
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}
