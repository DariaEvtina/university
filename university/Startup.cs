using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(university.Startup))]
namespace university
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
