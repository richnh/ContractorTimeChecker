using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractorTimeChecker.Startup))]
namespace ContractorTimeChecker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
