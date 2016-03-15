using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartupAttribute(typeof(SplitYourWebAppSample.Startup))]
namespace SplitYourWebAppSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}
