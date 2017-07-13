using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;
using AutoMapper;
using Pvara.Models;
using Microsoft.Practices.Unity;
using Pvara.Inerface;
using Pvara.Repository;

namespace Pvara
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // CORS  
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Tracing 
            config.EnableSystemDiagnosticsTracing();

            // AutoMapper
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Pivo, PivoDTO>();
                cfg.CreateMap<Pivo, PivoDetailDTO>();
                cfg.CreateMap<Pivara, PivaraDTO>();
                cfg.CreateMap<Pivara, PivaraDetailDTO>();
            });

            // Unity
            var container = new UnityContainer();
            container.RegisterType<IPivoRepository, PivoRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPivaraRepository, PivaraRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IVrstePivaRepository, VrstePivaRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);


        }
    }
}
