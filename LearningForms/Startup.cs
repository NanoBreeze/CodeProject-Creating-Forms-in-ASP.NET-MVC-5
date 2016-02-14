using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningForms.Startup))]
namespace LearningForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
