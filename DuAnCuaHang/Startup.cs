using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuAnCuaHang.Startup))]
namespace DuAnCuaHang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
