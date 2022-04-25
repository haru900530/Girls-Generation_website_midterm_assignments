using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WD7.Startup))]
namespace WD7
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
