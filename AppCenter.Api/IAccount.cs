using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace AppCenter.Api
{
    [Headers("X-API-Token: Bearer")]
    public interface IAccount
    {
        [Get("/v0.1/user")]
        Task<User> GetUser();

        [Get("/v0.1/user/export/serviceConnections")]
        Task<List<Connection>> GetServiceConnections();

        [Get("/v0.1/orgs/{org_name}/users")]
        Task<List<User>> GetUsers(string org_name);

        [Get("/v0.1/orgs/{org_name}/testers")]
        Task<List<User>> GetTesters(string org_name);

        [Get("/v0.1/orgs/{org_name}/teams/{team_name}/users")]
        Task<List<User>> GetTeamMembers(string org_name, string team_name);

        [Get("/v0.1/orgs/{org_name}/teams/{team_name}/apps")]
        Task<List<App>> GetTeamApps(string org_name, string team_name);

        [Get("/v0.1/orgs/{org_name}/teams/{team_name}")]
        Task<Team> GetTeam(string org_name, string team_name);

        [Get("/v0.1/orgs/{org_name}/teams")]
        Task<List<Team>> GetTeams(string org_name);

        [Get("/v0.1/orgs/{org_name}/invitations")]
        Task<List<Invitation>> GetInvitations(string org_name);
    }
}
