using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessStudy.Startup))]
namespace BusinessStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
