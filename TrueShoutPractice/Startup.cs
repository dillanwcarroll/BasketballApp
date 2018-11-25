using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrueShoutPractice.Startup))]
namespace TrueShoutPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
