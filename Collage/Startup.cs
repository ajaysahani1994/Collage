using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Collage.Startup))]
namespace Collage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
