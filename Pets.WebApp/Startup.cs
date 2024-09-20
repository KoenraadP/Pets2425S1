using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pets.WebApp.Startup))]
namespace Pets.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
