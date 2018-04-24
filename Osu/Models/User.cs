using Newtonsoft.Json;

namespace HGame.Osu.Models
{
    public class User
    {
        /// <summary>Player's user ID</summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>Player's username</summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>Total amount of 300s for all ranked, approved, and loved beatmaps played</summary>
        [JsonProperty("count300")]
        public string Count300 { get; set; }

        /// <summary>Total amount of 100s for all ranked, approved, and loved beatmaps played</summary>
        [JsonProperty("count100")]
        public string Count100 { get; set; }

        /// <summary>Total amount of 50s for all ranked, approved, and loved beatmaps played</summary>
        [JsonProperty("count50")]
        public string Count50 { get; set; }

        /// <summary>Play count of ranked, approved, and loved beatmaps</summary>
        [JsonProperty("playcount")]
        public string PlayCount { get; set; }

        /// <summary>Counts the best individual score on each ranked, approved, and loved beatmaps</summary>
        [JsonProperty("ranked_score")]
        public string RankedScore { get; set; }

        /// <summary>Counts every score on ranked, approved, and loved beatmaps</summary>
        [JsonProperty("total_score")]
        public string TotalScore { get; set; }

        /// <summary>Player's Performance Point rank</summary>
        [JsonProperty("pp_rank")]
        public string PPRank { get; set; }

        /// <summary>Player's level</summary>
        [JsonProperty("level")]
        public string Level { get; set; }

        /// <summary>Player's Performance Points, for inactive players this will be 0 to purge them from leaderboards</summary>
        [JsonProperty("pp_raw")]
        public string PPRaw { get; set; }

        /// <summary>Player's hit accuracy percentage</summary>
        [JsonProperty("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>Number of SS ranks on beatmaps</summary>
        [JsonProperty("count_rank_ss")]
        public string CountRankSS { get; set; }

        /// <summary>Number of SSH ranks on beatmaps</summary>
        [JsonProperty("count_rank_ssh")]
        public string CountRankSSH { get; set; }

        /// <summary>Number of S ranks on beatmaps</summary>
        [JsonProperty("count_rank_s")]
        public string CountRankS { get; set; }

        /// <summary>Number of SH ranks on beatmaps</summary>
        [JsonProperty("count_rank_sh")]
        public string CountRankSH { get; set; }

        /// <summary>Number of A ranks on beatmaps</summary>
        [JsonProperty("count_rank_a")]
        public string CountRankA { get; set; }

        /// <summary>Player's country code, uses the ISO3166-1 alpha-2 country code naming</summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>The user's rank in the country</summary>
        [JsonProperty("pp_country_rank")]
        public string PPCountryRank { get; set; }

        /// <summary>Contains events for this user</summary>
        [JsonProperty("events")]
        public Events[] Events { get; set; }
    }

    public class Events
    {
        /// <summary>Html tags for event</summary>
        [JsonProperty("display_html")]
        public string DisplayHtml { get; set; }

        /// <summary>Beatmap ID of event</summary>
        [JsonProperty("beatmap_id")]
        public string BeatmapID { get; set; }

        /// <summary>Beatmap set ID of event</summary>
        [JsonProperty("beatmapset_id")]
        public string BeatmapSetID { get; set; }

        /// <summary>Date event occurred</summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>How "epic" this event is (between 1 and 32)</summary>
        [JsonProperty("epicfactor")]
        public string EpicFactor { get; set; }
    }
}
