using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompetitionDb.Startup))]
namespace CompetitionDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
