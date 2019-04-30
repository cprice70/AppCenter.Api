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
        public static string Api_Token;//X-API-Token = "";
        static async Task Main(string[] args)
        {
            try
            {
                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
                Api_Token = config["ApiKey"];
                Task<string> GetHeaderValue() => Task.FromResult(Api_Token);
                var handler = new CustomHttpClientHandler(GetHeaderValue);
                var httpClient = new HttpClient(handler)
                {
                    BaseAddress = new Uri("https://api.appcenter.ms")
                };

                var appCenterApiUser = RestService.For<IAccount>(httpClient);
                var appCenterApiDist = RestService.For<IDistribute>(httpClient);

                var user = await appCenterApiUser.GetUser();
                System.Console.WriteLine(user.Name);

                var connection = await appCenterApiUser.GetServiceConnections();

                var users = await appCenterApiUser.GetUsers("onecontrol-w4m3");

                var testers = await appCenterApiUser.GetTesters("onecontrol-w4m3");

                var releases = await appCenterApiDist.GetAppReleases("onecontrol-w4m3", "OneControl-V3-Android");

                var recent_releases = await appCenterApiDist.GetAppRecentReleases("onecontrol-w4m3", "OneControl-V3-Android");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"{ex}");
            }
        }
    }

    class CustomHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<string>> _getHeaderValue;

        public CustomHttpClientHandler(Func<Task<string>> headerValue)
        {
            _getHeaderValue = headerValue ?? throw new ArgumentNullException(nameof(headerValue));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Remove("X-API-Token");
            request.Headers.Add("X-API-Token", await _getHeaderValue());

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
