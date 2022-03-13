using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test0.Startup))]
namespace test0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
