namespace OWIN_Self_Host_With_Assemblies_Resolver
{
    using Owin;
    using System.Web.Http;
    using System.Web.Http.Dispatcher;
    using System.Collections.Generic;
    using System.Reflection;

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            config.Services.Replace(typeof(IAssembliesResolver), new AssembliesResolver());
            app.UseWebApi(config);
        }
    }

    class AssembliesResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> assemblies = base.GetAssemblies();
            var apiAssembly = Assembly.LoadFrom(@"API.dll");
            assemblies.Add(apiAssembly);
            return assemblies;
        }
    }
}
