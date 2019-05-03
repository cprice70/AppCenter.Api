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

        [Get("/v0.1/orgs/{org_name}/distribution_groups_details")]
        Task<List<DistributionGroup>> GetDistributionGroupDetails(string org_name);

        [Get("/v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/members")]
        Task<List<User>> GetDistributionGroupMembers(string org_name, string distribution_group_name);

        [Get("/v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}/apps")]
        Task<List<App>> GetDistributionGroupApps(string org_name, string distribution_group_name);

        [Get("/v0.1/orgs/{org_name}/distribution_groups/{distribution_group_name}")]
        Task<DistributionGroupDetails> GetDistributionGroup(string org_name, string distribution_group_name);

        [Get("/v0.1/orgs/{org_name}/distribution_groups")]
        Task<List<DistributionGroupDetails>> GetDistributionGroups(string org_name);

        [Get("/v0.1/orgs/{org_name}/azure_subscriptions")]
        Task<List<AzureSubscription>> GetAzureSubscriptions(string org_name);

        [Get("/v0.1/orgs/{org_name}/apps")]
        Task<List<App>> GetApps(string org_name);

        [Get("/v0.1/orgs/{org_name}")]
        Task<Organization> GetOrganization(string org_name);

        [Get("/v0.1/orgs")]
        Task<List<Organization>> GetOrganizations();

        [Get("/v0.1/invitations/sent")]
        Task<List<Invitation>> GetInvitations();

        [Get("/v0.1/azure_subscriptions")]
        Task<List<AzureSubscription>> GetAzureSubscriptions();

        [Get("/v0.1/apps/{owner_name}/{app_name}")]
        Task<App> GetApp(string owner_name, string app_name);

        [Get("/v0.1/apps")]
        Task<List<App>> GetApps();

        [Get("/v0.1/api_tokens")]
        Task<List<Token>> GetTokens();
    }
}
