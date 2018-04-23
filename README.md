# H-Game
Asynchronous Video Game data API wrapper. Built originally for my Hifumi discord bot.
---
> **Supported APIs**
- [X] Steam
- [X] World of Warships

> **Future APIs**
- [ ] osu!

> **Add to Project**
Clone repository and add with Visual Studio or through .NET CLI
```shell
    dotnet add reference "path_to_cloned_repo/HGame.csproj"
```

> **Code Example**
```cs
    var client = new HGameClient(new HGameConfig
    {
        SteamKey = "YOUR_STEAM_KEY",
        WowsKey = "YOUR_WAR_GAMING_KEY"
    });

    var steamSearch = await client.Steam.RecentGamesAsync("12345678901234").ConfigureAwait(false);
    Console.WriteLine(steamSearch.RecentGames.TotalCount);

    List<string> usernames = new List<string>(new string[] { "Player Nickname" });
    var wowsSearch = await client.Wows.GetPlayersAsync(Region.Na, usernames).ConfigureAwait(false);
    Console.WriteLine(wowsSearch.PlayersList[0].AccountId);
```
