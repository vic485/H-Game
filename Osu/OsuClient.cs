using HGame.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace HGame.Osu
{
    public class OsuClient
    {
        readonly string key;
        public OsuClient(string apiKey) => key = apiKey;

        public async Task<string> GetUserAsync(string username, GameMode mode = 0, int eventDays = 1)
        {
            eventDays = (eventDays > 0 && eventDays < 32) ? eventDays : 1;
            JArray data = JArray.Parse(await HttpHelper.GetContentAsync(
                $"https://osu.ppy.sh/api/get_user?k={key}&u={username}&m={(int)mode}&event_days={eventDays}").ConfigureAwait(false));
            
            return data[0].ToString();
        }
    }

    public enum GameMode
    {
        Osu = 0,
        Taiko = 1,
        CtB = 2,
        OsuMania = 3
    }
}
