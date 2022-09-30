using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MUAT.Startup))]
namespace MUAT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
