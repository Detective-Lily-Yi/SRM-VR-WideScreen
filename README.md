# SRM-VR Wide Screen Mod

[![](https://shared.fastly.steamstatic.com/store_item_assets/steam/apps/3718190/98ac8863e8362f32687934637fe7a776bff8b34b/library_header_japanese_2x.jpg)](https://store.steampowered.com/app/3718190/)

This is a BepInEx 6 mod for SRM-VR (スーパーリアル麻雀 Venus Returns / Super Real Mahjong Venus Returns / 超真实麻将 Venus Returns). It forces custom display resolutions and removes the game's default letterboxing/pillarboxing (black borders).

You need [this patcher](https://github.com/Detective-Lily-Yi/SRM-VR-BepInEx-Patcher) to load the mod.

## Install

Download the dll from <https://github.com/Detective-Lily-Yi/SRM-VR-WideScreen/releases/latest>, put it in `<SRM-VR>\BepInEx\plugins\SRM-VR-WideScreen.dll`.

## Build

Clone the repo, open terminal, and run:

```powershell
dotnet build -c Release
```

Copies `SRM-VR-WideScreen.dll` to:

```text
<SRM-VR>\BepInEx\plugins\
```
