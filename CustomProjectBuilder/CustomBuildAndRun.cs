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
    public sealed class CustomBuildAndRun : EditorWindow
    {
        private const string Hotkey = "%F1";
        private const string BuildFolderName = "Builds";
        private const string ApplicationExecutionFormat = ".exe";
        private static string ProductName => PlayerSettings.productName;

        private int numberOfPlayers = 1;

        [MenuItem("RimuruDev Tools/Build and Run + Play Editor Mode " + Hotkey)]
        public static void ShowWindow()
        {
            GetWindow(typeof(CustomBuildAndRun));
        }

        private void OnGUI()
        {
            GUILayout.Label("Build Settings", EditorStyles.boldLabel);

            numberOfPlayers = EditorGUILayout.IntField("Number of Players:", numberOfPlayers);

            if (GUILayout.Button("Build and Run"))
            {
                var buildConfigs = GenerateBuildConfigurations(numberOfPlayers);
                foreach (var buildConfig in buildConfigs)
                {
                    BuildAndRunInstance(buildConfig);
                }
            }
        }

        private static List<BuildPlayerOptions> GenerateBuildConfigurations(int numberOfPlayers)
        {
            var buildConfigs = new List<BuildPlayerOptions>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                var scenes = GetScenesInBuild();
                var buildPath = Path.Combine(GetProjectPath(), BuildFolderName, $"{ProductName}_Players_{i + 1}");

                Directory.CreateDirectory(buildPath);

                var buildPlayerOptions = SetupProjectSettingsForBuild(scenes, buildPath);
                buildConfigs.Add(buildPlayerOptions);
            }

            return buildConfigs;
        }

        private static void BuildAndRunInstance(BuildPlayerOptions buildPlayerOptions)
        {
            var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
            var summary = report.summary;

            if (summary.result == BuildResult.Succeeded)
            {
                Process.Start(Path.Combine(buildPlayerOptions.locationPathName));

                EditorApplication.isPlaying = true;
            }
            else if (summary.result == BuildResult.Failed)
            {
                Debug.LogError("Build failed");
            }
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

        private static string GetProjectPath()
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
    }
}
