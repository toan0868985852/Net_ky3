using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3.Startup))]
namespace lab3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
