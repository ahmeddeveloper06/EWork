using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EWork.Startup))]
namespace EWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
