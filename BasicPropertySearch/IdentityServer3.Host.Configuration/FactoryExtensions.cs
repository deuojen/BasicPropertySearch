using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Services;
using IdentityServer3.Host.Extension;

namespace IdentityServer3.Host.Configuration
{
    static class FactoryExtensions
    {
        public static IdentityServerServiceFactory AddCustomGrantValidators(this IdentityServerServiceFactory factory)
        {
            factory.CustomGrantValidators.Add(
                    new Registration<ICustomGrantValidator, CustomGrantValidator>());
            factory.CustomGrantValidators.Add(
                new Registration<ICustomGrantValidator, AnotherCustomGrantValidator>());

            return factory;
        }

        public static IdentityServerServiceFactory AddCustomTokenResponseGenerator(this IdentityServerServiceFactory factory)
        {
            factory.CustomTokenResponseGenerator =
                new Registration<ICustomTokenResponseGenerator, CustomTokenResponseGenerator>();

            return factory;
        }
    }
}
