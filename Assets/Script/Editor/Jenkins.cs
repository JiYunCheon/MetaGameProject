using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class Jenkins : MonoBehaviour
{
    [UnityEditor.MenuItem("MyMenu/Build/ProjectBuild", false, 1)]

    static void PerformBuild()
    {

        string curDir = Directory.GetCurrentDirectory() + "\\Build\\";
        string[] scenes = UnityEditor.EditorBuildSettingsScene.GetActiveSceneList(UnityEditor.EditorBuildSettings.scenes);
        BuildPipeline.BuildPlayer(scenes, "./Build/Mygame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }

}
