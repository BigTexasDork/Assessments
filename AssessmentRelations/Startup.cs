using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssessmentRelations.Startup))]
namespace AssessmentRelations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
