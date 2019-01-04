using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;

namespace Identity.Client
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });
            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = "https://localhost:44346/identity",
                ClientId = "mvc",
                RedirectUri = "https://localhost:44363/", // Client
                ResponseType = "id_token",
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active,
                SignInAsAuthenticationType = "Cookies"
            });
        }
    }
}