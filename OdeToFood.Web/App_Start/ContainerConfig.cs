﻿using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using ClassLibrary1.Services;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlRestaurantData>().As<IResturantData>().InstancePerRequest();

            builder.RegisterType<OdeToFoodsDbContext>().InstancePerRequest();

            var Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(Container);

        }
    }
}