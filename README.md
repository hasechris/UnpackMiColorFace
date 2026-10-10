# UnpackMiColorFace

Watchfaces unpacker utility for Xiaomi watches:
(70 mai, Longcheer & others)

- Xiaomi Watch Color,
- Xiaomi Watch Color Sport,
- Xiaomi Mi Watch,
- Xiaomi Mi Revolve,
- Xiaomi Mi Revolve Active,
- Xiaomi Watch Color 2
- Xiaomi Watch S1 (Chinese and Global)
- Xiaomi Watch S1 Active
- Xiaomi Watch S1 Pro,
- Xiaomi Redmi Watch 2
- Xiaomi Redmi Watch 2 Lite,
- Xiaomi Redmi Watch 3,
- Xiaomi Redmi Watch 3 Active,
- Xiaomi Mi Band 7 Pro
- Xiaomi Watch S2 (Chinese)
- Xiaomi Watch S3 (Chinese and Global)
- Xioami Mi Band 8
- Xiaomi Mi Band 8 Pro
- Xiaomi Redmi Watch 4
- Xiaomi Redmi Watch 4 Active (in release soon)
- Xioami Mi Band 9
- Xioami Mi Band 9 Pro (in release soon)
- Xiaomi Redmi Watch 5 (in release soon)

## Build on Linux with VS Code

Install the .NET 10 SDK and the recommended VS Code extension. On Manjaro, the SDK can be installed with:

```sh
sudo pacman -S dotnet-sdk
```

Open this repository folder in VS Code, then build with **Terminal > Run Build Task** or:

```sh
dotnet build UnpackMiColorFace.csproj
```

Run the unpacker with:

```sh
dotnet run --project UnpackMiColorFace.csproj -- /path/to/watchface.bin
```

The build restores Magick.NET from NuGet. `XiaomiWatch.Common.dll` is referenced from the repository's `lib` directory and copied to the build output.
