using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3WebSessionManagement.Startup))]
namespace _3WebSessionManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
