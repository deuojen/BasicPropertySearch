using IdentityServer3.Core;
using IdentityServer3.Core.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer3.Host.Config
{
    public static class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                /////////////////////////////////////////////////////////////
                // MVC OWIN Implicit Client
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "MVC OWIN Implicit Client",
                    ClientId = "mvc.owin.implicit",
                    Flow = Flows.Implicit,
                    AllowAccessTokensViaBrowser = false,

                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.Address,
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44301/"
                    },

                    LogoutUri = "https://localhost:44301/Home/SignoutCleanup",
                    LogoutSessionRequired = true,
                },
            };
        }
    }
}
