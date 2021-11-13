using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qsrbncms.Startup))]
namespace qsrbncms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
