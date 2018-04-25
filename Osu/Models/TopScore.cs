using Newtonsoft.Json;

namespace HGame.Osu.Models
{
    public class TopScore
    {
        /// <summary>ID of the score</summary>
        [JsonProperty("score_id")]
        public string ScoreID { get; set; }

        /// <summary>Score point value</summary>
        [JsonProperty("score")]
        public string Score { get; set; }

        /// <summary>Username of the player</summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>Number of 300 hits</summary>
        [JsonProperty("count300")]
        public string Count300 { get; set; }

        /// <summary>Number of 100 hits</summary>
        [JsonProperty("count100")]
        public string Count100 { get; set; }

        /// <summary>Number of 50 hits</summary>
        [JsonProperty("count50")]
        public string Count50 { get; set; }

        /// <summary>Number of misses</summary>
        [JsonProperty("countmiss")]
        public string CountMiss { get; set; }

        /// <summary>Max combo the player achieved</summary>
        [JsonProperty("maxcombo")]
        public string MaxCombo { get; set; }

        /// <summary>Number of Kat(s)u hits</summary>
        [JsonProperty("countkatu")]
        public string CountKatu { get; set; }

        /// <summary>Number of Geki hits</summary>
        [JsonProperty("countgeki")]
        public string CountGeki { get; set; }

        /// <summary>If the player played a perfect match, 1 = max combo achieved, 0 = max combo not achieved</summary>
        [JsonProperty("perfect")]
        public string Perfect { get; set; }

        /// <summary>Bitwise flag of mods used</summary>
        [JsonProperty("enabled_mods")]
        public string EnabledMods { get; set; }

        /// <summary>Player's user ID</summary>
        [JsonProperty("user_id")]
        public string UserID { get; set; }

        /// <summary>Date match was played</summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>Rank player achieved</summary>
        [JsonProperty("rank")]
        public string Rank { get; set; }

        /// <summary>Performance points gained</summary>
        [JsonProperty("pp")]
        public string PP { get; set; }

        /// <summary>Is the replay hosted by osu! 1 = yes, 0 = no</summary>
        [JsonProperty("replay_available")]
        public string ReplayAvailable { get; set; }
    }
}
