using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentWithAngular.Startup))]
namespace AssignmentWithAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
