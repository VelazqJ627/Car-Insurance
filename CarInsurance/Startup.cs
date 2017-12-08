using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarInsurance.Startup))]
namespace CarInsurance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
