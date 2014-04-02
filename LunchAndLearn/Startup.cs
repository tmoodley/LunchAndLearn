using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LunchAndLearn.Startup))]
namespace LunchAndLearn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
