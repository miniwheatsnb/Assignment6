using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPet.Startup))]
namespace MvcPet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
