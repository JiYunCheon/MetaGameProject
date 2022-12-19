using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

//class ProjectBuild
//{
//    static string[] SCENES = FindEnabledEditorScenes();
//    static string APP_NAME = "TestBuild";

//    [MenuItem("Custom/Build/Build Windows")]
//    static void PerformWindowsBuild()
//    {
//        string target_filename = APP_NAME + ".exe";
//        GenericBuild(SCENES, target_filename, BuildTarget.StandaloneWindows64, BuildOptions.None);
//    }

//    private static string[] FindEnabledEditorScenes()
//    {
//        List<string> EditorScenes = new List<string>();
//        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
//        {
//            if (!scene.enabled) continue;
//            EditorScenes.Add(scene.path);
//        }
//        return EditorScenes.ToArray();
//    }

//    static void GenericBuild(string[] scenes, string target_filename, BuildTarget build_target, BuildOptions build_options)
//    {
//        BuildPipeline.BuildPlayer(scenes, target_filename, build_target, build_options);

//    }
//}
public class Jenkins
{
    static string APP_NAME = "MetaProgramming_2";

    [UnityEditor.MenuItem("TestBuild/ProjectBuild", false, 1)]
    static void PerformBuild()
    {
        if (!Directory.Exists(Directory.GetCurrentDirectory() + "/Build/"))
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Build/");
        }

        string target_filename = APP_NAME + ".exe";
        string[] scenes = EditorBuildSettingsScene.GetActiveSceneList(EditorBuildSettings.scenes);

        GenericBuild(scenes, target_filename, BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    static void GenericBuild(string[] scenes, string target_filename, BuildTarget build_target, BuildOptions build_options)
    {
        BuildPipeline.BuildPlayer(scenes, Directory.GetCurrentDirectory() + "/Build/" + target_filename, build_target, build_options);
    }
}
