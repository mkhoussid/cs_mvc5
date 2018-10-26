using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mijem_test_app.Startup))]
namespace Mijem_test_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
