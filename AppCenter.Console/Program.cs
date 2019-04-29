using System;
using System.Threading.Tasks;
using AppCenter.Api;
using Refit;

namespace AppCenter.Console
{
    class Program
    {
        static readonly string api_token = "PUT API KEY HERE";//X-API-Token = "";
        static async Task Main(string[] args)
        {
            try
            {
                var appCenterApiUser = RestService.For<IAccount>("https://api.appcenter.ms");
                var appCenterApiDist = RestService.For<IDistribute>("https://api.appcenter.ms");

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
}
