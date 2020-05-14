using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlastairMicallef_Enterprise.Startup))]
namespace AlastairMicallef_Enterprise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
