using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorProject.Startup))]
namespace CalculatorProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
