using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignmenttttt_1.Startup))]
namespace Assignmenttttt_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
