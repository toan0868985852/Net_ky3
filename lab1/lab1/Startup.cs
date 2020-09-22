using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab1.Startup))]
namespace lab1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
