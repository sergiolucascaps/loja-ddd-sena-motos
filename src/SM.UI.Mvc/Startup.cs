using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SM.UI.Mvc.Startup))]
namespace SM.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
