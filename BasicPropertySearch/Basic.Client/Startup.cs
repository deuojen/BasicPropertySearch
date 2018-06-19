using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System.Collections.Generic;
using System.IdentityModel.Tokens;

namespace Basic.Client
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            JwtSecurityTokenHandler.InboundClaimTypeMap = new Dictionary<string, string>();

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                ClientId = "mvc.owin.implicit",
                Authority = "https://localhost:44333/core",
                RedirectUri = "https://localhost:44301/",
                ResponseType = "id_token access_token",
                Scope = "openid email",

                UseTokenLifetime = false,
                SignInAsAuthenticationType = "Cookies",
            });
        }
    }
}