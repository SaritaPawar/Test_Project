using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBridge.Startup))]
namespace MVCBridge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
