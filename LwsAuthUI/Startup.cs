using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LwsAuthUI.Startup))]
namespace LwsAuthUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
