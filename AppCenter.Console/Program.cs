using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AppCenter.Api;
using Microsoft.Extensions.Configuration;
using Refit;

namespace AppCenter.Console
{
    class Program
    {
        public static string Api_Token;
        public static string Owner;
        public static string App;

        static async Task Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("AppCenter Api Test App");

                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
                Api_Token = config["ApiKey"];
                Owner = config["Owner"];
                App = config["App"];
                Task<string> GetHeaderValue() => Task.FromResult(Api_Token);
                var handler = new ApiKeyHttpClientHandler(GetHeaderValue);
                var httpClient = new HttpClient(handler)
                {
                    BaseAddress = new Uri("https://api.appcenter.ms")
                };

                var appCenterApiUser = RestService.For<IAccount>(httpClient);
                var appCenterApiDist = RestService.For<IDistribute>(httpClient);

                System.Console.WriteLine("Retrieving User Info");

                var user = await appCenterApiUser.GetUser();
                System.Console.WriteLine(user.Name);

                var connections = await appCenterApiUser.GetServiceConnections();
                System.Console.WriteLine($"Number of Connections: {connections.Count}");

                var users = await appCenterApiUser.GetUsers(Owner);
                System.Console.WriteLine($"Number of Users: {users.Count}");

                var testers = await appCenterApiUser.GetTesters(Owner);
                System.Console.WriteLine($"Number of Testers: {testers.Count}");

                var releases = await appCenterApiDist.GetAppReleases(Owner, App);
                System.Console.WriteLine($"Number of Releases: {releases.Count}");

                var recent_releases = await appCenterApiDist.GetAppRecentReleases(Owner, App);
                System.Console.WriteLine($"Number of Recent Releases: {recent_releases.Count}");

                var subs = await appCenterApiUser.GetAzureSubscriptions();
                System.Console.WriteLine($"Number of Azure Subscriptions: {subs.Count}");

                var invites = await appCenterApiUser.GetInvitations();
                System.Console.WriteLine($"Number of Invitations: {invites.Count}");

                var orgs = await appCenterApiUser.GetOrganizations();
                System.Console.WriteLine($"Number of Organizations: {orgs.Count}");

                foreach (var org in orgs)
                {
                    System.Console.WriteLine($"Organization Name {org.Name}");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"{ex}");
            }
        }
    }
}
