using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlgorithmsWebApp.Startup))]
namespace AlgorithmsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
