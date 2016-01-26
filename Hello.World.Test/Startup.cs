using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello.World.Test.Startup))]
namespace Hello.World.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
