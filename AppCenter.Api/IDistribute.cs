using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace AppCenter.Api
{
    [Headers("X-API-Token: KEY")]
    public interface IDistribute
    {
        [Get("/v0.1/apps/{owner_name}/{app_name}/releases")]
        Task<List<Release>> GetAppReleases(string owner_name, string app_name);

        [Get("/v0.1/apps/{owner_name}/{app_name}/recent_releases")]
        Task<List<Release>> GetAppRecentReleases(string owner_name, string app_name);
    }
}
