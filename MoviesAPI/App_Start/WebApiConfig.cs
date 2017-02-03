﻿using Microsoft.Practices.Unity;
using MoviesAPI.Controllers;
using MoviesAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MoviesAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var container = new UnityContainer();
            container.RegisterType<IWebJetWrapperService, WebJetWrapperService>(new HierarchicalLifetimeManager());
            container.RegisterType<IConfigurationService, ConfigurationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IMovieServicesFactory, MovieServicesFactory>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);

            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{provider}",
                defaults: new { id = RouteParameter.Optional , provider = RouteParameter.Optional}
            );
        }
    }
}
