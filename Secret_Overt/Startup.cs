using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Secret_Overt.Startup))]
namespace Secret_Overt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
