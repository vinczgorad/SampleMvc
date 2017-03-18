using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample.Web.Mvc.Startup))]
namespace Sample.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
