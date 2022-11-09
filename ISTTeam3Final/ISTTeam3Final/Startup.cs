using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISTTeam3Final.Startup))]
namespace ISTTeam3Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
