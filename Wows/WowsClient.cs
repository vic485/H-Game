using HGame.Helpers;
using HGame.Wows.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HGame.Wows
{
    public class WowsClient
    {
        readonly string key;
        public WowsClient(string clientId) => key = clientId;

        /// <summary>Find a user's account id</summary>
        /// <param name="region">Server region to search</param>
        /// <param name="usernames">List of usernames</param>
        public async Task<Players> GetPlayersAsync(Region region, List<string> usernames)
            => JsonConvert.DeserializeObject<Players>(await HttpHelper.GetContentAsync(
                $"{ApiUrl(region)}list/?application_id={key}&search={string.Join(",", usernames)}&type=exact"
            ).ConfigureAwait(false));

        /// <summary>Get personal profile data for players</summary>
        /// <param name="region">Server region to search</param>
        /// <param name="userids">List of account ids</param>
        public async Task<List<PlayerPersonalData>> GetPlayerDataAsync(Region region, List<string> userids)
        {
            List<PlayerPersonalData> data = new List<PlayerPersonalData>();
            JToken dataToken = JToken.Parse(await HttpHelper.GetContentAsync(
                $"{ApiUrl(region)}info/?application_id={key}&account_id={string.Join(",", userids)}").ConfigureAwait(false))["data"];
            
            foreach (string userid in userids)
            {
                data.Add(dataToken[userid].ToObject<PlayerPersonalData>());
            }
            return data;
        }

        string ApiUrl(Region r)
        {
            string tld = null;
            switch (r)
            {
                case Region.Ru: tld = "ru"; break;
                case Region.Eu: tld = "eu"; break;
                case Region.Na: tld = "com"; break;
                case Region.Asia: tld = "asia"; break;
            }
            return $"https://api.worldofwarships.{tld}/wows/account/";
        }
    }

    public enum Region
    {
        Ru,
        Eu,
        Na,
        Asia
    }
}
