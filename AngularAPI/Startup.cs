using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularAPI.Startup))]
namespace AngularAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
