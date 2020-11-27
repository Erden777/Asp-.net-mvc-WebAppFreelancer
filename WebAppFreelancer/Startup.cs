using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppFreelancer.Startup))]
namespace WebAppFreelancer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
