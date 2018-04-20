using HGame.Helpers;
using HGame.Steam.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HGame.Steam
{
    public class SteamClient
    {
        readonly string key;
        public SteamClient(string apiKey) => key = apiKey;

        /// <summary>Get information about (a) Steam user(s).</summary>
        /// <param name="userIds">List of user ids.</param>
        public async Task<PlayerSummaries> GetUsersInfoAsync(List<string> userIds)
            => JsonConvert.DeserializeObject<PlayerSummaries>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={key}&steamids={string.Join(",", userIds)}").ConfigureAwait(false));

        /// <summary>Get a player's friend list.</summary>
        /// <param name="userId">Player's user id.</param>
        public async Task<PlayerFriendList> GetFriendListAsync(string userId)
            => JsonConvert.DeserializeObject<PlayerFriendList>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/ISteamUser/GetFriendList/v0001/?key={key}&steamid={userId}").ConfigureAwait(false));

        /// <summary>Get a player's list of games.</summary>
        /// <param name="userId">Player's user id.</param>
        public async Task<PlayerOwnedGames> OwnedGamesAsync(string userId)
            => JsonConvert.DeserializeObject<PlayerOwnedGames>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={key}&steamid={userId}").ConfigureAwait(false));

        /// <summary>Get a list of a player's recently played games.</summary>
        /// <param name="userId">Player's user id.</param>
        public async Task<PlayerRecentGames> RecentGamesAsync(string userId)
            => JsonConvert.DeserializeObject<PlayerRecentGames>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v0001/?key={key}&steamid={userId}").ConfigureAwait(false));

        /// <summary>Get ban information about (a) user(s)</summary>
        /// <param name="userIds">List of user ids.</param>
        public async Task<PlayerBans> PlayerBansAsync(List<string> userIds)
            => JsonConvert.DeserializeObject<PlayerBans>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/ISteamUser/GetPlayerBans/v1/?key={key}&steamids={string.Join(",", userIds)}").ConfigureAwait(false));

        /// <summary>Get information about a game.</summary>
        /// <param name="appId">Game's application id.</param>
        public async Task<SchemaForGames> GetSchemaForGamesAsync(string appId)
            => JsonConvert.DeserializeObject<SchemaForGames>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v2/?key={key}&appid={appId}").ConfigureAwait(false));

        /// <summary>Get a list of a player's achievements for a game.</summary>
        /// <param name="appId">Game's application id.</param>
        /// <param name="userId">Player's user id.</param>
        public async Task<PlayerAchievements> GetAchievementsAsync(string appId, string userId)
            => JsonConvert.DeserializeObject<PlayerAchievements>(await HttpHelper.GetContentAsync(
                $"http://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v0001/?appid={appId}&key={key}&steamid={userId}").ConfigureAwait(false));
    }
}
