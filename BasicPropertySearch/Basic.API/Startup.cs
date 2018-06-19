using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;
using Basic.API;
using System.IdentityModel.Tokens;
using System.Web.Http;
using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using Basic.API.BLL.DB.InMemory;
using Basic.API.BLL.DB.Repositories.Interfaces;
using Basic.API.BLL.DB.Repositories;
using AutoMapper;
using Basic.API.Models;
using Basic.API.BLL.DB.Entity;

[assembly: OwinStartup(typeof(Basic.API.Startup))]

namespace Basic.API
{

    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {

        /// <summary>
        /// 
        /// </summary>
        private static readonly log4net.ILog log =
                    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            log.Info("Application Starting...");

            var config = new HttpConfiguration();
            JwtSecurityTokenHandler.InboundClaimTypeMap.Clear();

            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "https://localhost:44333/core",
                RequiredScopes = new[] { "write" },

                // client credentials for the introspection endpoint
                //ClientId = "write",
                //ClientSecret = "secret"
            });

            RegisterAutofac(app, config);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PropertyModel, Property>();
                cfg.CreateMap<SearchParametersModel, SearchParameters>();
            });



            SwaggerConfig.Register(config);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        private static void RegisterAutofac(IAppBuilder app, HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<InMemoryProperties>().InstancePerRequest();

            builder.RegisterType<FakePropertyRepository>().As<IPropertyRepository>().InstancePerRequest();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Run other optional steps, like registering filters,
            // per-controller-type services, etc., then set the dependency resolver
            // to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // OWIN WEB API SETUP:

            // Register the Autofac middleware FIRST, then the Autofac Web API middleware,
            // and finally the standard Web API middleware.
            app.UseAutofacMiddleware(container);
        }
    }
}