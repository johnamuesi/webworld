using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebWorld.Startup))]
namespace WebWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
