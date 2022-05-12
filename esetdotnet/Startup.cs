using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(esetdotnet.Startup))]
namespace esetdotnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
