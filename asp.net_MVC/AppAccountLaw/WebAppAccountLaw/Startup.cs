using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAccountLaw.Startup))]
namespace WebAppAccountLaw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
