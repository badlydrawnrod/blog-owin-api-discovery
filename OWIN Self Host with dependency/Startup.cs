namespace OWIN_Self_Host_With_Dependency
{
    using Owin;
    using System.Web.Http;

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
            app.UseWebApi(config);
        }
    }
}
