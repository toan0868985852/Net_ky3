using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Movie.Startup))]
namespace MVC_Movie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
