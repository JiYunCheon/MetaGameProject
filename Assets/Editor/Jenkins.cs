using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class Jenkins : MonoBehaviour
{
    static string APP_NAME = "MetaProgramming2";

    [UnityEditor.MenuItem("TestBuild/Build/ProjectBuild", false, 1)]
    static void PerformBuild()
    {
        string target_filename = APP_NAME + ".exe";
        string curDir = Directory.GetCurrentDirectory() + "\\Build\\";
        string[] scenes = UnityEditor.EditorBuildSettingsScene.GetActiveSceneList(UnityEditor.EditorBuildSettings.scenes);
        GenericBuild(scenes, target_filename, BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    static void GenericBuild(string[] scenes, string target_filename, BuildTarget build_target, BuildOptions build_options)
    {
        BuildPipeline.BuildPlayer(scenes, target_filename, build_target, build_options);
    }
}
