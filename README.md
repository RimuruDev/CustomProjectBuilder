[English](README.md) | [Русский](README_RU.md)

<p align="center"><h1>⭐Custom Build and Run Utility for Unity⭐</h1></p>
 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/CustomProjectBuilder?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/CustomProjectBuilder?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/CustomProjectBuilder?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/CustomProjectBuilder/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/CustomProjectBuilder?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/CustomProjectBuilder?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/CustomProjectBuilder?style=flat">
  </a>
</p>

## Overview

Custom Build and Run is a Unity editor extension designed to streamline the testing and development process of multiplayer games using Unity and Nakama Server. With just a single command, it automates the building and launching of a standalone game instance alongside entering Play Mode in the Unity Editor, allowing you to test matchmaking and in-game interactions seamlessly.

## Why Use Custom Build and Run?

This utility addresses the common challenge of testing multiplayer interactions in Unity. Traditionally, testing such features requires manual coordination between building the game, running multiple instances, and managing server connections. Custom Build and Run simplifies this into one step, saving time and reducing errors.

## Features

- **One-Click Build and Run**: Compile and run a standalone game instance with preconfigured settings using a single menu command or hotkey.
- **Simultaneous Editor Play Mode**: Automatically enters Play Mode in the Unity Editor post-build, enabling immediate testing of multiplayer features.
- **Streamlined Workflow**: Focus on development and testing rather than repetitive setup tasks, enhancing productivity and iteration speed.

## Installation

1. Clone this repository or download the latest release.
2. Import the `CustomBuildAndRun.cs` script into your Unity project's Editor folder.
3. Access the utility through the `RimuruDev Tools` menu or by pressing the assigned hotkey (`%F1` by default).

## Usage

After installation, the utility can be triggered via the editor menu `RimuruDev Tools/Build and Run + Play Editor Mode` or by using the hotkey `%F1`. Ensure your scenes are properly configured in the Build Settings and that the Nakama server is running.

### Building and Running

Use the menu command or hotkey to initiate the build. The utility will:

- Compile the game into a predefined build folder.
- Launch the built game instance.
- Enter Play Mode in the Unity Editor automatically.

```plaintext
RimuruDev Tools/Build and Run + Play Editor Mode %F1
```
# Hotkey - ctrl + F1

![image](https://github.com/RimuruDev/CustomProjectBuilder/assets/85500556/82c0e829-66e8-482b-8bb6-6d4e56363c72)


## Dependencies
Unity Editor: Ensure you have Unity Editor installed.

[//]: # (Nakama Server: A running instance of Nakama Server is required for multiplayer testing.)

## Contributing
If you have suggestions for improving the utility or have encountered issues, please feel free to contribute:

- Fork the repository.
- Create your feature branch (git checkout -b feature/AmazingFeature).
- Commit your changes (git commit -am 'Add some AmazingFeature').
- Push to the branch (git push origin feature/AmazingFeature).
- Open a pull request.

[//]: # (## License)
[//]: # (This project is licensed under the MIT License - see the LICENSE.md file for details.)

### Developed by RimuruDev