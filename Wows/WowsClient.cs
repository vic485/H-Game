using HGame.Helpers;
using HGame.Wows.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.IO; // REMOVE: Only needed for testing

namespace HGame.Wows
{
    public class WowsClient
    {
        readonly string key;
        public WowsClient(string clientId) => key = clientId;

        // TODO: Api Calls
        public async Task<Players> GetPlayersAsync(Region region, string username)
            => JsonConvert.DeserializeObject<Players>(await HttpHelper.GetContentAsync(
                $"{ApiUrl(region)}list/?application_id={key}&search={username}&type=exact"
            ).ConfigureAwait(false));

        public async Task<PlayerPersonalData> GetPlayerDataAsync(Region region, string userid)
        {
            JToken dataToken = JToken.Parse(await HttpHelper.GetContentAsync(
                $"{ApiUrl(region)}info/?application_id={key}&account_id={userid}").ConfigureAwait(false))["data"];
            File.WriteAllText("./test.json", dataToken.ToString());
            PlayerPersonalData playerData = dataToken[userid].ToObject<PlayerPersonalData>();
            File.WriteAllText("./playertest.json", dataToken[userid].ToString());
            return playerData;
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
