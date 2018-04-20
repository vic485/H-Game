using HGame.Steam;

namespace HGame
{
    public class HGameClient
    {
        public SteamClient Steam { get; set; }

        public HGameClient(HGameConfig config)
        {
            Steam = new SteamClient(config.SteamKey);
        }
    }
}
