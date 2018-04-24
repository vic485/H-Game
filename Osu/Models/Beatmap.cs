using Newtonsoft.Json;

namespace HGame.Osu.Models
{
    public class Beatmap
    {
        /// <summary>Approval state of beatmap; 4 = loved, 3 = qualified, 2 = approved, 1 = ranked, 0 = pending, -1 = WIP, -2 = graveyard</summary>
        [JsonProperty("approved")]
        public string Approved { get; set; }

        /// <summary>Date ranked, UTC+8</summary>
        [JsonProperty("approved_date")]
        public string ApprovedDate { get; set; }

        /// <summary>Last time beatmap was updated, UTC+8</summary>
        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        /// <summary>Artist of song in beatmap</summary>
        [JsonProperty("artist")]
        public string Artist { get; set; }

        /// <summary>Beatmap ID, per difficulty</summary>
        [JsonProperty("beatmap_id")]
        public string BeatmapID { get; set; }

        /// <summary>ID of set of beatmap difficulties</summary>
        [JsonProperty("beatmapset_id")]
        public string BeatmapSetID { get; set; }

        /// <summary>BPM of song</summary>
        [JsonProperty("bpm")]
        public string BPM { get; set; }

        /// <summary>User who created the beatmap</summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>Star difficulty rating</summary>
        [JsonProperty("difficultyrating")]
        public string DifficultyRating { get; set; }

        /// <summary>Circle size value</summary>
        [JsonProperty("diff_size")]
        public string DiffSize { get; set; }

        /// <summary>Overall difficulty</summary>
        [JsonProperty("diff_overall")]
        public string DiffOverall { get; set; }

        /// <summary>Approach rate</summary>
        [JsonProperty("diff_approach")]
        public string DiffApproach { get; set; }

        /// <summary>Health drain</summary>
        [JsonProperty("diff_drain")]
        public string DiffDrain { get; set; }

        /// <summary>Seconds from first note to last note, not including breaks</summary>
        [JsonProperty("hit_length")]
        public string HitLength { get; set; }

        /// <summary>Beatmap source</summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>Song genre; 0 = any, 1 = unspecified, 2 = video game, 3 = anime, 4 = rock, 5 = pop, 6 = other, 7 = novelty, 9 = hip hop, 10 = electronicF</summary>
        [JsonProperty("genre_id")]
        public string GenreID { get; set; }

        /// <summary>Song language; 0 = any, 1 = other, 2 = english, 3 = japanese, 4 = chinese, 5 = instrumental, 6 = korean, 7 = french, 8 = german, 9 = swedish, 10 = spanish, 11 = italian</summary>
        [JsonProperty("language_id")]
        public string LanguageID { get; set; }

        /// <summary>Song title</summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>Seconds from first note to last note, including breaks</summary>
        [JsonProperty("total_length")]
        public string TotalLength { get; set; }

        /// <summary>Difficulty name</summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>MD5 hash of the beatmap</summary>
        [JsonProperty("file_md5")]
        public string FileMd5 { get; set; }

        /// <summary>Game mode</summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>Beatmap tags, separated by spaces</summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>Number of times the beatmap was favourited</summary>
        [JsonProperty("favourite_count")]
        public string FavouriteCount { get; set; }

        /// <summary>Number of times the beatmap was played</summary>
        [JsonProperty("playcount")]
        public string PlayCount { get; set; }

        /// <summary>Number of times the beatmap was passed, completed (no fails or retries)</summary>
        [JsonProperty("passcount")]
        public string PassCount { get; set; }

        /// <summary>Max combo a user can reach playing the beatmap</summary>
        [JsonProperty("max_combo")]
        public string MaxCombo { get; set; }
    }
}
