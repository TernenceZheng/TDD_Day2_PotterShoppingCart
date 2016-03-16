using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PotterShoppingCart.Startup))]
namespace PotterShoppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
