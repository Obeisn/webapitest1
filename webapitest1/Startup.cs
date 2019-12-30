using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapitest1.Startup))]
namespace webapitest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
