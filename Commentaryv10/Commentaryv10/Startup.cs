using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Commentaryv10.Startup))]
namespace Commentaryv10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
