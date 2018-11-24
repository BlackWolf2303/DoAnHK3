using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerShop2.Startup))]
namespace FlowerShop2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
