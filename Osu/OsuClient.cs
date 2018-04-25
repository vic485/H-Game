using HGame.Helpers;
using HGame.Osu.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HGame.Osu
{
    public class OsuClient
    {
        readonly string key;
        public OsuClient(string apiKey) => key = apiKey;

        /// <summary>Retrieve general beatmap information</summary>
        /// <param name="date">Return all beatmaps ranked or loved since this date</param>
        /// <param name="beatmapSetID">Beatmap set ID to return data from</param>
        /// <param name="beatmapID">Beatmap ID to return data from</param>
        /// <param name="user">User id or username to get data for</param>
        /// <param name="type">Whether name is a username or ID (default is username)</param>
        /// <param name="mode">Game mode (If not supplied, all modes will be included)</param>
        /// <param name="converted">Specify whether converted beatmaps are included (0 = not included, 1 = included)</param>
        /// <param name="hash">Beatmap hash, all beatmaps will be returned if left blank</param>
        /// <param name="limit">Amount of results, max is 500</param>
        public async Task<List<Beatmap>> GetBeatmapsAsync(DateTime date, string beatmapSetID, string beatmapID, string user, UserType type = 0, GameMode? mode = null, int converted = 0, string hash = null, int limit = 500)
        {
            // TODO: Check string building
            string mysqlDate = date.ToString("yyy-MM-dd HH:mm:ss");
            string url = $"https://osu.ppy.sh/api/get_beatmaps?k={key}&since={mysqlDate}&s={beatmapSetID}&b={beatmapID}&u={user}&type={GetType(type)}";
            if (mode.HasValue) url += $"&m={(int)mode.Value}";
            if (mode.HasValue && mode.Value != GameMode.Osu) url += $"&a={IntHelper.Clamp(converted, 0, 1)}";
            if (!string.IsNullOrWhiteSpace(hash)) url += $"&h={hash}";
            url += $"&limit={IntHelper.Clamp(limit, 1, 500)}";

            JArray data = JArray.Parse(await HttpHelper.GetContentAsync(url).ConfigureAwait(false));
            List<Beatmap> beatmaps = new List<Beatmap>();
            foreach (var beatmap in data)
                beatmaps.Add(beatmap.ToObject<Beatmap>());

            return beatmaps;
        }

        /// <summary>Retrieve general user information</summary>
        /// <param name="name">Username or user ID to search by</param>
        /// <param name="mode">Game mode (default is osu!)</param>
        /// <param name="type">Whether name is a username or ID (default is username)</param>
        /// <param name="eventDays">Max number of days between now and last event (range of 1 - 31, default is 1)</param>
        public async Task<List<User>> GetUserAsync(string name, GameMode mode = 0, UserType type = 0, int eventDays = 1)
        {
            eventDays = IntHelper.Clamp(eventDays, 1, 31);
            JArray data = JArray.Parse(await HttpHelper.GetContentAsync(
                $"https://osu.ppy.sh/api/get_user?k={key}&u={name}&m={(int)mode}&type={GetType(type)}&event_days={eventDays}").ConfigureAwait(false));

            List<User> users = new List<User>();
            foreach (var user in data)
                users.Add(user.ToObject<User>());

            return users;
        }

        /// <summary>Retrieve information about the top 100 scores of a specified beatmap</summary>
        /// <param name="beatmapID">ID of the beatmap to return score information from</param>
        /// <param name="name">Username of player to get score of (optional)</param>
        /// <param name="mode">Game mode, default is osu!</param>
        /// <param name="mods">Bitwise enum of a mod or mod combination</param>
        /// <param name="type">Whether name is a username or ID (default is username)</param>
        /// <param name="limit">Amount of results from the top to return (1 - 100, default is 50)</param>
        public async Task<List<TopScore>> GetScoreAsync(string beatmapID, string name = null, GameMode mode = 0, GameMods? mods = null, UserType type = 0, int limit = 50)
        {
            string url = $"https://osu.ppy.sh/api/get_scores?k={key}&b={beatmapID}";
            if (!string.IsNullOrWhiteSpace(name)) url += $"&u={name}";
            url += $"&m={(int)mode}";
            if (mods.HasValue) url += $"&mods={mods.Value}";
            if (!string.IsNullOrWhiteSpace(name)) url += $"&type={GetType(type)}";
            url += $"&limit={IntHelper.Clamp(limit, 1, 100)}";
            JArray data = JArray.Parse(await HttpHelper.GetContentAsync(url).ConfigureAwait(false));

            List<TopScore> scores = new List<TopScore>();
            foreach (var score in data)
                scores.Add(score.ToObject<TopScore>());

            return scores;
        }

        string GetType(UserType type)
        {
            switch (type)
            {
                case UserType.UserId: return "id";
                case UserType.Username: return "string";
            }
            return "string"; // Return "string" because username is the osu api default
        }
    }

    public enum GameMode
    {
        Osu = 0,
        Taiko = 1,
        CtB = 2,
        OsuMania = 3
    }

    public enum UserType
    {
        Username,
        UserId
    }

    public enum GameMods
    {
        None = 0,
        NoFail = 1,
        Easy = 2,
        NoVideo = 4, // Not used anymore, but can be found on old plays like Mesita on b/78239
        Hidden = 8,
        HardRock = 16,
        SuddenDeath = 32,
        DoubleTime = 64,
        Relax = 128,
        HalfTime = 256,
        Nightcore = 512, // Only set along with DoubleTime. i.e: NC only gives 576
        Flashlight = 1024,
        Autoplay = 2048,
        SpunOut = 4096,
        Relax2 = 8192,  // Autopilot?
        Perfect = 16384, // Only set along with SuddenDeath. i.e: PF only gives 16416  
        Key4 = 32768,
        Key5 = 65536,
        Key6 = 131072,
        Key7 = 262144,
        Key8 = 524288,
        keyMod = Key4 | Key5 | Key6 | Key7 | Key8,
        FadeIn = 1048576,
        Random = 2097152,
        LastMod = 4194304,
        FreeModAllowed = NoFail | Easy | Hidden | HardRock | SuddenDeath | Flashlight | FadeIn | Relax | Relax2 | SpunOut | keyMod,
        Key9 = 16777216,
        Key10 = 33554432,
        Key1 = 67108864,
        Key3 = 134217728,
        Key2 = 268435456
    }
}
