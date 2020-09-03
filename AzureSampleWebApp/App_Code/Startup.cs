using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureSampleWebApp.Startup))]
namespace AzureSampleWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
