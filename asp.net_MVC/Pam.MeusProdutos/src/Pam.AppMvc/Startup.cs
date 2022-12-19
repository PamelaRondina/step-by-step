using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pam.AppMvc.Startup))]
namespace Pam.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
