using Newtonsoft.Json;
using System.Collections.Generic;

namespace HGame.Wows.Models
{
    public class PlayerData
    {
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
    }

    public class Players
    {
        [JsonProperty("data")]
        public List<PlayerData> PlayerList { get; set; }
    }
}
