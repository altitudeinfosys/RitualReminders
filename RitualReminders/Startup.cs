using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RitualReminders.Startup))]
namespace RitualReminders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
