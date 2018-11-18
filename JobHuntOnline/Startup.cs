using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobHuntOnline.Startup))]
namespace JobHuntOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
