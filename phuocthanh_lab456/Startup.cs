using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phuocthanh_lab456.Startup))]
namespace phuocthanh_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
