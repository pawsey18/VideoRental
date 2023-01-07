using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(VideoRentalsApp.StartupOwin))]

namespace VideoRentalsApp
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
