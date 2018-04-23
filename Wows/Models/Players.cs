using Newtonsoft.Json;
using System.Collections.Generic;

namespace HGame.Wows.Models
{
    public class PlayerData
    {
        /// <summary>Player name</summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>Player ID</summary>
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
    }

    public class Players
    {
        /// <summary>List of players, in order of ids supplied</summary>
        [JsonProperty("data")]
        public List<PlayerData> PlayerList { get; set; }
    }
}
