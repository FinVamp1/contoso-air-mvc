using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoAirMVC.Startup))]
namespace ContosoAirMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
