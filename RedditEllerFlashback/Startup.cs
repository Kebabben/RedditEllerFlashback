using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedditEllerFlashback.Startup))]
namespace RedditEllerFlashback
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
