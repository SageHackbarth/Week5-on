using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SageHackbarthWeek5.Web.Startup))]
namespace SageHackbarthWeek5.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
