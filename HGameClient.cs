using HGame.Steam;
using HGame.Osu;
using HGame.Wows;

namespace HGame
{
    public class HGameClient
    {
        public SteamClient Steam { get; set; }
        public OsuClient Osu {get;set;}
        public WowsClient Wows { get; set; }

        public HGameClient(HGameConfig config)
        {
            Steam = new SteamClient(config.SteamKey);
            Osu = new OsuClient(config.OsuKey);
            Wows = new WowsClient(config.WowsKey);
        }
    }
}
