using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HGame.Wows.Models
{
    // TODO: May need to make some fields nullable
    public class PlayerPersonalData
    {
        [JsonProperty("last_battle_time")]
        public ulong LastBattleTime { get; set; }
        [JsonProperty("account_id")]
        public ulong AccountId { get; set; }
        [JsonProperty("leveling_tier")]
        public ulong LevelingTier { get; set; }
        [JsonProperty("created_at")]
        public ulong CreatedAt { get; set; }
        [JsonProperty("leveling_points")]
        public ulong LevelingPoints { get; set; }
        [JsonProperty("updated_at")]
        public ulong UpdatedAt { get; set; }
        [JsonProperty("private")]
        public string Private { get; set; } // TODO: This is an object. Probably should not include private data.
        [JsonProperty("hidden_profile")]
        public bool HiddenProfile { get; set; } // Is this a private profile? Respect this setting.
        [JsonProperty("logout_at")]
        public ulong LogoutAt { get; set; }
        [JsonProperty("karma")]
        public ulong? Karma { get; set; } // TODO: disabled field
        [JsonProperty("statistics")]
        public PlayerStatistics Statistics { get; set; }
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        [JsonProperty("stats_updated_at")]
        public ulong StatsUpdatedAt { get; set; }
    }

    public class PlayerStatistics
    {
        [JsonProperty("distance")]
        public ulong Distance { get; set; }
        [JsonProperty("battles")]
        public ulong Battles { get; set; }
        [JsonProperty("pvp")]
        public PlayerPVP PVP { get; set; }
    }

    public class PlayerPVP
    {
        [JsonProperty("max_xp")]
        public ulong MaxXP { get; set; }
        [JsonProperty("damage_to_buildings")]
        public ulong DamageToBuildings { get; set; }
        [JsonProperty("main_battery")]
        public PlayerMainBattery MainBattery { get; set; }
        [JsonProperty("max_ships_spotted_ship_id")]
        public ulong MaxShipsSpottedShipId { get; set; }
        [JsonProperty("max_damage_scouting")]
        public ulong MaxDamageScouting { get; set; }
        [JsonProperty("art_agro")]
        public ulong ArtAgro { get; set; }
        [JsonProperty("max_xp_ship_id")]
        public ulong MaxXPShipId { get; set; }
        [JsonProperty("ships_spotted")]
        public ulong ShipsSpotted { get; set; }
        [JsonProperty("second_battery")]
        public PlayerSecondaryBattery SecondaryBattery { get; set; }
        [JsonProperty("max_frags_ship_id")]
        public ulong MaxFragsShipId { get; set; }
        [JsonProperty("xp")]
        public ulong XP { get; set; }
        [JsonProperty("survived_battles")]
        public ulong SurvivedBattles { get; set; }
        [JsonProperty("dropped_capture_points")]
        public ulong DroppedCapturePoints { get; set; }
        [JsonProperty("max_damage_dealt_to_buildings")]
        public ulong MaxDamageDealtToBuildings { get; set; }
        [JsonProperty("torpedo_agro")]
        public ulong TorpedoAgro { get; set; }
        [JsonProperty("draws")]
        public ulong Draws { get; set; }
        [JsonProperty("control_captured_points")]
        public ulong ControlCapturedPoints { get; set; }
        [JsonProperty("max_total_agro_ship_id")]
        public ulong MaxTotalAgroShipId { get; set; }
        [JsonProperty("planes_killed")]
        public ulong PlanesKilled { get; set; }
        [JsonProperty("battles")]
        public ulong Battles { get; set; }
        [JsonProperty("max_ships_spotted")]
        public ulong MaxShipsSpotted { get; set; }
        [JsonProperty("max_suppressions_ship_id")]
        public ulong? MaxSuppressionsShipId { get; set; }
        [JsonProperty("survived_wins")]
        public ulong SurvivedWins { get; set; }
        [JsonProperty("frags")]
        public ulong Frags { get; set; }
        [JsonProperty("damage_scouting")]
        public ulong DamageScouting { get; set; }
        [JsonProperty("max_total_agro")]
        public ulong MaxTotalAgro { get; set; }
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }
        [JsonProperty("capture_points")]
        public ulong CapturePoints { get; set; }
        [JsonProperty("ramming")]
        public PlayerRamming Ramming { get; set; }
        [JsonProperty("suppressions_count")]
        public ulong SuppressionsCount { get; set; }
        [JsonProperty("max_suppressions_count")]
        public ulong MaxSuppressionsCount { get; set; }
        [JsonProperty("torpedoes")]
        public PlayerTorpedoes Torpedoes { get; set; }
        [JsonProperty("max_planes_killed_ship_id")]
        public ulong? MaxPlanesKilledShipId { get; set; }
        [JsonProperty("aircraft")]
        public PlayerAircraft Aircraft { get; set; }
        [JsonProperty("team_capture_points")]
        public ulong TeamCapturePoints { get; set; }
        [JsonProperty("control_dropped_points")]
        public ulong ControlDroppedPoints { get; set; }
        [JsonProperty("max_damage_dealt")]
        public ulong MaxDamageDealt { get; set; }
        [JsonProperty("max_damage_dealt_to_buildings_ship_id")]
        public ulong? MaxDamageDealtToBuildingsShipId { get; set; }
        [JsonProperty("max_damage_dealt_ship_id")]
        public ulong MaxDamageDealtShipId { get; set; }
        [JsonProperty("wins")]
        public ulong Wins { get; set; }
        [JsonProperty("losses")]
        public ulong Losses { get; set; }
        [JsonProperty("damage_dealt")]
        public ulong DamageDealt { get; set; }
        [JsonProperty("max_planes_killed")]
        public ulong MaxPlanesKilled { get; set; }
        [JsonProperty("max_scouting_damage_ship_id")]
        public ulong MaxScoutingDamageShipId { get; set; }
        [JsonProperty("team_dropped_capture_points")]
        public ulong TeamDroppedCapturePoints { get; set; }
        [JsonProperty("battles_since_512")]
        public ulong BattlesSince512 { get; set; }
    }

    public class PlayerMainBattery
    {
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }
        [JsonProperty("frags")]
        public ulong Frags { get; set; }
        [JsonProperty("hits")]
        public ulong Hits { get; set; }
        [JsonProperty("max_frags_ship_id")]
        public ulong MaxFragsShipId { get; set; }
        [JsonProperty("shots")]
        public ulong Shots { get; set; }
    }

    public class PlayerSecondaryBattery
    {
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }
        [JsonProperty("frags")]
        public ulong Frags { get; set; }
        [JsonProperty("hits")]
        public ulong Hits { get; set; }
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }
        [JsonProperty("shots")]
        public ulong Shots { get; set; }
    }

    public class PlayerRamming
    {
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }
        [JsonProperty("frags")]
        public ulong Frags { get; set; }
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }
    }

    public class PlayerTorpedoes
    {
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }
        [JsonProperty("frags")]
        public ulong Frags { get; set; }
        [JsonProperty("hits")]
        public ulong Hits { get; set; }
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }
        [JsonProperty("shots")]
        public ulong Shots { get; set; }
    }

    public class PlayerAircraft
    {
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }
        [JsonProperty("frags")]
        public ulong Frags { get; set; }
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }
    }
}
