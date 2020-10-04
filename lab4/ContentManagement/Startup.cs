using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContentManagement.Startup))]
namespace ContentManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
