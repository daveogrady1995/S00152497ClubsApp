using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00152497Clubs.Startup))]
namespace S00152497Clubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
