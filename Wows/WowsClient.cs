using HGame.Helpers;
using HGame.Wows.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

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
