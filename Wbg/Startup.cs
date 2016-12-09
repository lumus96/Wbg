using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wbg.Startup))]
namespace Wbg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
