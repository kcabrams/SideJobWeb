using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SideJobWeb.Startup))]
namespace SideJobWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
