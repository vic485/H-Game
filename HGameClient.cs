using HGame.Steam;
using HGame.Wows;

namespace HGame
{
    public class HGameClient
    {
        public SteamClient Steam { get; set; }
        public WowsClient Wows { get; set; }

        public HGameClient(HGameConfig config)
        {
            Steam = new SteamClient(config.SteamKey);
            Wows = new WowsClient(config.WowsKey);
        }
    }
}
