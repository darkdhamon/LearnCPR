using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnCPR.Startup))]
namespace LearnCPR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
