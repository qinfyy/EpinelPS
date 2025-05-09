# EpinelPS

---

<div align="center">

[![GitHub issues](https://img.shields.io/github/issues/MishaProductions/nikke-server?style=flat-square)](https://github.com/MishaProductions/nikke-server/issues)
[![GitHub pr](https://img.shields.io/github/issues-pr/MishaProductions/nikke-server?style=flat-square)](https://github.com/MishaProductions/nikke-server/pulls)
[![GitHub](https://img.shields.io/github/license/MishaProductions/nikke-server?style=flat-square)](https://github.com/MishaProductions/nikke-server/blob/main/LICENSE)
![GitHub release (with filter)](https://img.shields.io/github/downloads-pre/MishaProductions/nikke-server/latest/total?style=flat-square)
![GitHub Repo stars](https://img.shields.io/github/stars/MishaProductions/nikke-server?style=flat-square)
[![Discord](https://img.shields.io/discord/1261717212448952450?style=flat-square)](https://discord.gg/Ztt6Y9vQjF)

</div>
Private/local server for a 2d anime rpg game. The goal of this project is to replicate the functionality of the official server. Discord server: https://discord.gg/Ztt6Y9vQjF

> [!CAUTION]
> Please note this GitHub repository (https://github.com/EpinelPS/EpinelPS/) is the only official source for EpinelPS. **If you bought it from someone, you got scammed. Do not download EpinelPS from other sources.** Download link: https://nightly.link/EpinelPS/EpinelPS/workflows/dotnet-desktop/main/Server%20and%20Server%20selector.zip

> [!WARNING]
> This project is in an early state so many functions in the game do not work. It is recommended to download the latest build from GitHub actions.

## Usage
Download the latest release/GitHub actions build, and run ServerSelector.Desktop.exe as administrator (to modify DNS hosts file and install a CA cert). Make sure to close the game and launcher first. Select Local server, and then click save. After that, start EpinelPS.exe to start the actual server.
<br>
<img src="https://github.com/MishaProductions/nikke-server/assets/106913236/b01194ef-aec5-4de9-b982-1253757655f8" width="192" height="108">
<br>
You should be able to register an new account in the launcher (you can enter any email verification code).

To access the admin panel, go to https://127.0.0.1/admin/ and sign in. Note that IsAdmin needs to be true for the user account. Note that this interface does not have anything yet.

To skip stages, a basic command line interface is implemented.


## TODO: 
 - [X] Campaign (Normal, Hard, Lost items, Rewards, Subquests)
 - [X] Lobby
 - [X] Save team info
 - [X] Profile UI
 - [X] Open Archives UI
 - [X] Inventory system
 - [X] Character level up
 - [X] Side story
 - [X] Archives
 - [X] Outpost Rewards
 - [X] Skill level up
 - [X] Daily, weekly missions etc
 - [X] Outpost jukebox
 - [X] Messenger
 - [ ] Simulation Room
 - [ ] Lost sector
 - [ ] Basic friend list support
 - [ ] Admin Panel
 - [ ] Change events in Admin Panel
 - [ ] Arcade
 - [ ] Limit temporary participation
 
## What is not working:
 - Events
 - Outpost buildings, recycle room, infrastructure core
 - Interception rewards, simulation room
 - And a lot more...
