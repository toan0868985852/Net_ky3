using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab1._1._1.Startup))]
namespace lab1._1._1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
