using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobHuntOnline.WebTemplate.Startup))]
namespace JobHuntOnline.WebTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
