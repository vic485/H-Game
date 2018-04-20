# H-Game
Asynchronous Video Game data API wrapper. Built originally for my Hifumi discord bot.
---
> **Supported APIs**
- [X] Steam

> **Future APIs**
- [ ] osu!
- [ ] World of Warships

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

    var wowsSearch = await client.Wows.GetPlayersAsync(Region.Na, "Player Nickname").ConfigureAwait(false);
    Console.WriteLine(wowsSearch.PlayersList[0].AccountId);
```
