using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HGame.Wows.Models
{
    // TODO: May need to make some fields nullable
    public class PlayerPersonalData
    {
        /// <summary>Last battle time</summary>
        [JsonProperty("last_battle_time")]
        public ulong LastBattleTime { get; set; }

        /// <summary>User ID</summary>
        [JsonProperty("account_id")]
        public ulong AccountId { get; set; }

        /// <summary>Service Record level</summary>
        [JsonProperty("leveling_tier")]
        public ulong LevelingTier { get; set; }

        /// <summary>Date when player's account was created</summary>
        [JsonProperty("created_at")]
        public ulong CreatedAt { get; set; }

        /// <summary>Service Record points</summary>
        [JsonProperty("leveling_points")]
        public ulong LevelingPoints { get; set; }

        /// <summary>Date when player details were updated</summary>
        [JsonProperty("updated_at")]
        public ulong UpdatedAt { get; set; }

        /// <summary>Player's private data</summary>
        [JsonProperty("private")]
        public string Private { get; set; } // TODO: This is an object. Probably should not include private data.

        /// <summary>Indicates if the game profile is hidden</summary>
        [JsonProperty("hidden_profile")]
        public bool HiddenProfile { get; set; } // Is this a private profile? Respect this setting.

        /// <summary>End time of last game session</summary>
        [JsonProperty("logout_at")]
        public ulong LogoutAt { get; set; }

        /// <summary>Player's karma</summary>
        [JsonProperty("karma")]
        public ulong? Karma { get; set; } // TODO: disabled field

        /// <summary>Player statistics</summary>
        [JsonProperty("statistics")]
        public PlayerStatistics Statistics { get; set; }

        /// <summary>Player name</summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>Date when stats for player and player's ships were updated</summary>
        [JsonProperty("stats_updated_at")]
        public ulong StatsUpdatedAt { get; set; }
    }

    public class PlayerStatistics
    {
        /// <summary>Miles travelled</summary>
        [JsonProperty("distance")]
        public ulong Distance { get; set; }

        /// <summary>Battles fought</summary>
        [JsonProperty("battles")]
        public ulong Battles { get; set; }

        /// <summary>Player statistics in all Random Battles</summary>
        [JsonProperty("pvp")]
        public PlayerPVP PVP { get; set; }
    }

    public class PlayerPVP
    {
        /// <summary>Maximum Experience Points per battle, including XP earned with Premium Account</summary>
        [JsonProperty("max_xp")]
        public ulong MaxXP { get; set; }

        /// <summary>Damage dealt to installations, starting from version 5.12</summary>
        [JsonProperty("damage_to_buildings")]
        public ulong DamageToBuildings { get; set; }

        /// <summary>Main battery firing statistics</summary>
        [JsonProperty("main_battery")]
        public PlayerMainBattery MainBattery { get; set; }

        /// <summary>Ship that detected the most enemy ships</summary>
        [JsonProperty("max_ships_spotted_ship_id")]
        public ulong MaxShipsSpottedShipId { get; set; }

        /// <summary>Most damage caused by allies to enemy ships spotted by the player</summary>
        [JsonProperty("max_damage_scouting")]
        public ulong MaxDamageScouting { get; set; }

        /// <summary>Potential damage caused by shells</summary>
        [JsonProperty("art_agro")]
        public ulong ArtAgro { get; set; }

        /// <summary>Warship used to gain maximum Experience Points per battle, including XP earned with Premium Account</summary>
        [JsonProperty("max_xp_ship_id")]
        public ulong MaxXPShipId { get; set; }

        /// <summary>Ships spotted by the player first</summary>
        [JsonProperty("ships_spotted")]
        public ulong ShipsSpotted { get; set; }

        /// <summary>Secondary armament firing statistics</summary>
        [JsonProperty("second_battery")]
        public PlayerSecondaryBattery SecondaryBattery { get; set; }

        /// <summary>ID of a ship with maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_ship_id")]
        public ulong MaxFragsShipId { get; set; }

        /// <summary>Total Experience Points, including XP earned with Premium Account</summary>
        [JsonProperty("xp")]
        public ulong XP { get; set; }

        /// <summary>Battles survived</summary>
        [JsonProperty("survived_battles")]
        public ulong SurvivedBattles { get; set; }

        /// <summary>Total number of defense points</summary>
        [JsonProperty("dropped_capture_points")]
        public ulong DroppedCapturePoints { get; set; }

        /// <summary>Most damage caused to installations in a battle</summary>
        [JsonProperty("max_damage_dealt_to_buildings")]
        public ulong MaxDamageDealtToBuildings { get; set; }

        /// <summary>Potential damage caused by torpedoes</summary>
        [JsonProperty("torpedo_agro")]
        public ulong TorpedoAgro { get; set; }

        /// <summary>Draws</summary>
        [JsonProperty("draws")]
        public ulong Draws { get; set; }

        /// <summary>Base capture points</summary>
        [JsonProperty("control_captured_points")]
        public ulong ControlCapturedPoints { get; set; }

        /// <summary>Ship that caused the most potential damage</summary>
        [JsonProperty("max_total_agro_ship_id")]
        public ulong MaxTotalAgroShipId { get; set; }

        /// <summary>Enemy aircraft destroyed</summary>
        [JsonProperty("planes_killed")]
        public ulong PlanesKilled { get; set; }

        /// <summary>Battles fought</summary>
        [JsonProperty("battles")]
        public ulong Battles { get; set; }

        /// <summary>Most ships detected</summary>
        [JsonProperty("max_ships_spotted")]
        public ulong MaxShipsSpotted { get; set; }

        /// <summary>Ship that surpressed the most installations</summary>
        [JsonProperty("max_suppressions_ship_id")]
        public ulong? MaxSuppressionsShipId { get; set; }

        /// <summary>Victories in battles survived</summary>
        [JsonProperty("survived_wins")]
        public ulong SurvivedWins { get; set; }

        /// <summary>Warships destroyed</summary>
        [JsonProperty("frags")]
        public ulong Frags { get; set; }

        /// <summary>Damage caused by allies</summary>
        [JsonProperty("damage_scouting")]
        public ulong DamageScouting { get; set; }

        /// <summary>Most potential damage caused by ammunition that hit or fell near the ship</summary>
        [JsonProperty("max_total_agro")]
        public ulong MaxTotalAgro { get; set; }

        /// <summary>Maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }

        /// <summary>Total number of capture points</summary>
        [JsonProperty("capture_points")]
        public ulong CapturePoints { get; set; }

        /// <summary>Statistics of ramming enemy warships</summary>
        [JsonProperty("ramming")]
        public PlayerRamming Ramming { get; set; }

        /// <summary>Number of installations surpressed, starting from version 5.12</summary>
        [JsonProperty("suppressions_count")]
        public ulong SuppressionsCount { get; set; }

        /// <summary>Most installations surpressed in a battle</summary>
        [JsonProperty("max_suppressions_count")]
        public ulong MaxSuppressionsCount { get; set; }

        /// <summary>Statistics of attacking targets with torpedoes</summary>
        [JsonProperty("torpedoes")]
        public PlayerTorpedoes Torpedoes { get; set; }

        /// <summary>Warship with maximum number of enemy aircraft destroyed</summary>
        [JsonProperty("max_planes_killed_ship_id")]
        public ulong? MaxPlanesKilledShipId { get; set; }

        /// <summary>Statistics of aircraft used</summary>
        [JsonProperty("aircraft")]
        public PlayerAircraft Aircraft { get; set; }

        /// <summary>Total number of base capture points earned by the player's team</summary>
        [JsonProperty("team_capture_points")]
        public ulong TeamCapturePoints { get; set; }

        /// <summary>Base defense points</summary>
        [JsonProperty("control_dropped_points")]
        public ulong ControlDroppedPoints { get; set; }

        /// <summary></summary>
        [JsonProperty("max_damage_dealt")]
        public ulong MaxDamageDealt { get; set; }

        /// <summary></summary>
        [JsonProperty("max_damage_dealt_to_buildings_ship_id")]
        public ulong? MaxDamageDealtToBuildingsShipId { get; set; }

        /// <summary>Maximum Damage caused per battle</summary>
        [JsonProperty("max_damage_dealt_ship_id")]
        public ulong MaxDamageDealtShipId { get; set; }

        /// <summary>Victories</summary>
        [JsonProperty("wins")]
        public ulong Wins { get; set; }

        /// <summary>Defeats</summary>
        [JsonProperty("losses")]
        public ulong Losses { get; set; }

        /// <summary>Damage caused</summary>
        [JsonProperty("damage_dealt")]
        public ulong DamageDealt { get; set; }

        /// <summary>Maximum number of aircraft destroyed per battle</summary>
        [JsonProperty("max_planes_killed")]
        public ulong MaxPlanesKilled { get; set; }

        /// <summary>Ship that caused the most damage to enemy ships spotted by the player</summary>
        [JsonProperty("max_scouting_damage_ship_id")]
        public ulong MaxScoutingDamageShipId { get; set; }

        /// <summary>Total number of base defense points earned by the player's team</summary>
        [JsonProperty("team_dropped_capture_points")]
        public ulong TeamDroppedCapturePoints { get; set; }

        /// <summary>Number of battles, starting from version 5.12</summary>
        [JsonProperty("battles_since_512")]
        public ulong BattlesSince512 { get; set; }
    }

    public class PlayerMainBattery
    {
        /// <summary>Maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }

        /// <summary>Warships destroyed</summary>
        [JsonProperty("frags")]
        public ulong Frags { get; set; }

        /// <summary>Hits</summary>
        [JsonProperty("hits")]
        public ulong Hits { get; set; }

        /// <summary>ID of a ship with maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_ship_id")]
        public ulong MaxFragsShipId { get; set; }

        /// <summary>Shots fired</summary>
        [JsonProperty("shots")]
        public ulong Shots { get; set; }
    }

    public class PlayerSecondaryBattery
    {
        /// <summary>Maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }

        /// <summary>Warships destroyed</summary>
        [JsonProperty("frags")]
        public ulong Frags { get; set; }

        /// <summary>Hits</summary>
        [JsonProperty("hits")]
        public ulong Hits { get; set; }

        /// <summary>ID of a ship with maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }

        /// <summary>Shots fired</summary>
        [JsonProperty("shots")]
        public ulong Shots { get; set; }
    }

    public class PlayerRamming
    {
        /// <summary>Maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }

        /// <summary>Warships destroyed</summary>
        [JsonProperty("frags")]
        public ulong Frags { get; set; }

        /// <summary>ID of a ship with maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }
    }

    public class PlayerTorpedoes
    {
        /// <summary>Maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }

        /// <summary>Warships destroyed</summary>
        [JsonProperty("frags")]
        public ulong Frags { get; set; }

        /// <summary>Hits</summary>
        [JsonProperty("hits")]
        public ulong Hits { get; set; }

        /// <summary>ID of a ship with maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }

        /// <summary>Shots fired</summary>
        [JsonProperty("shots")]
        public ulong Shots { get; set; }
    }

    public class PlayerAircraft
    {
        /// <summary>Maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_battle")]
        public ulong MaxFragsBattle { get; set; }

        /// <summary>Warships destroyed</summary>
        [JsonProperty("frags")]
        public ulong Frags { get; set; }

        /// <summary>ID of a ship with maximum number of enemy warships destroyed per battle</summary>
        [JsonProperty("max_frags_ship_id")]
        public ulong? MaxFragsShipId { get; set; }
    }
}
