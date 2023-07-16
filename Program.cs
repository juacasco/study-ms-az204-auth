using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace study_az204_auth
{
    class Program
    {
        private const string _clientId = "34e7da97-f435-4992-85c4-5d92a5d68852";
        private const string _tenantId = "565eda1a-74b4-4dcc-a98d-a5db4ff69dbf";
        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
                .Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost")
                .Build();

            string[] scopes = {"user.read"};
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token: \t{result.AccessToken}");
        }
    }
}




