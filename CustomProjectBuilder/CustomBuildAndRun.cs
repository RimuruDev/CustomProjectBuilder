// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

// Hotkey Ctrl + F1
// Download the finished package from Relese and import it.
// Or download this script, transfer it to any Editor folder in the Unity project.
// Now in the upper part of the Unity editor you will see the panel for building the project.
// After clicking on build, the script will build the project and immediately launch it, as well as launch the project in open Unity (Enter Play Mode).

using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;

namespace RimuruDev.External.RimuruDevUtils.CustomProjectBuilder
{
    public sealed class CustomBuildAndRun
    {
        private const string Hotkey = "%F1";
        private const string BuildFolferName = "Builds";
        private const string ApplicationExecutionFormat = ".exe";
        private static readonly string ProductName = PlayerSettings.productName;

        [MenuItem("RimuruDev Tools/Build and Run + Play Editor Mode" + Hotkey)]
        public static void BuildAndRun()
        {
            var buildPath = Path.Combine(GetProgetPath(), BuildFolferName);

            Directory.CreateDirectory(buildPath);

            var scenes = GetScenesInBuild();

            if (scenes.Count == 0)
            {
                Debug.LogError("No scenes are enabled in the build settings");
                return;
            }

            var buildPlayerOptions = SetupProjectSettingsForBuild(scenes, buildPath);

            BuildProject(buildPlayerOptions, buildPath);
        }

        private static BuildPlayerOptions SetupProjectSettingsForBuild(List<string> scenes, string buildPath)
        {
            var buildPlayerOptions = new BuildPlayerOptions
            {
                scenes = scenes.ToArray(),
                locationPathName = Path.Combine(buildPath, ProductName + ApplicationExecutionFormat),
                target = BuildTarget.StandaloneWindows,
                options = BuildOptions.None
            };
            return buildPlayerOptions;
        }

        private static string GetProgetPath()
        {
            var path = Path.GetDirectoryName(Application.dataPath);

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException($"{nameof(Application.dataPath)} not found!");

            return path;
        }

        private static List<string> GetScenesInBuild() => EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToList();

        private static void BuildProject(BuildPlayerOptions buildPlayerOptions, string buildPath)
        {
            var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            var summary = report.summary;

            if (summary.result == BuildResult.Succeeded)
            {
                Process.Start(Path.Combine(buildPath, ProductName + ApplicationExecutionFormat));

                EditorApplication.isPlaying = true;
            }
            else if (summary.result == BuildResult.Failed)
            {
                Debug.LogError("Build failed");
            }
        }
    }
}
