using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPB2_HFA.Startup))]
namespace WebAppPB2_HFA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
