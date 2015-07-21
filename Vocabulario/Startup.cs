using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vocabulario.Startup))]
namespace Vocabulario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
