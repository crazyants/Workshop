using System.Web.Http;
using Owin;


namespace Divergent.Customers.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.EnableCors();

            app.UseWebApi(config);
        }
    }
}
