using System;
using System.IO;
using UnityEditor;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

public class Builds : Editor
{
    [MenuItem("Build/Build Android")]
    private static void BuildAndroid()
    {
        EditorApplication.SaveScene();
        Build(BuildTarget.Android, Selection.objects);
    }
	
    private static void Build(BuildTarget bt, Object[] objects)
    {
        Directory.CreateDirectory("maps");
        if (objects == null || objects.Length == 0)
        {
            if (string.IsNullOrEmpty(EditorApplication.currentScene)) throw new Exception("Scene is null");
            objects = new Object[] { AssetDatabase.LoadAssetAtPath(EditorApplication.currentScene, typeof(Object)) };
        }
        foreach (var a in objects)
        {
            try
            {
                Debug.Log(a.name + ": Successfuly builded" + BuildPipeline.BuildStreamedSceneAssetBundle(new[] { AssetDatabase.GetAssetPath(a) }, "maps/" + a.name + ".unity3d" + bt, bt));
				File.AppendAllText("maplist.txt", a.name + ".unity3d" + bt + "\r\n");
            } catch (Exception e)
            {
                Debug.LogError(e);
            }
        }
    }

}
