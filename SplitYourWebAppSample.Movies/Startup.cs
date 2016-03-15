using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(SplitYourWebAppSample.Movies.Startup))]

namespace SplitYourWebAppSample.Movies
{
    public class Startup
    {        

        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/account/login"),
                Provider = new CookieAuthenticationProvider
                {
                    OnApplyRedirect = context =>
                    {                    
                        context.Response.Redirect("http://localhost:48000/account/login");
                    }
                }                
            });
           
        }
    }
}
