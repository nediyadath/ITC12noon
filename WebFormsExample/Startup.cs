using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsExample.Startup))]
namespace WebFormsExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
