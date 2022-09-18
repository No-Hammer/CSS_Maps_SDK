#if UNITY_EDITOR
using UnityEngine;
using UGUIMiniMap;
using UnityEditor;
using System;
using UnityEngine.SceneManagement;
using System.IO;

[ExecuteInEditMode, RequireComponent(typeof(Camera), typeof(RectTransform))]
public class SnapShot : MonoBehaviour
{
    public int TextureSize = 512;
    public int antiAliasing = 1;
    public string snapshotPath = "";
    [Space(7)]
    [InspectorButton("TakeSnapshot")]
    public string m_TakeSnapShot = "";
    [Space(7)]
    [InspectorButton("GenerateOverview")]
    public string m_GenerateOverview = "";
    

    [ContextMenu("Take Snap Shot")]
    public void TakeSnapshot()
    {
        RenderTexture rt = new RenderTexture(TextureSize, TextureSize, 24);
        rt.antiAliasing = antiAliasing;
        rt.filterMode = FilterMode.Trilinear;
        GetComponent<Camera>().targetTexture = rt;
        Texture2D snapshot = new Texture2D(TextureSize, TextureSize, TextureFormat.RGB24, false);
        GetComponent<Camera>().Render();
        RenderTexture.active = rt;
        snapshot.ReadPixels(new Rect(0, 0, TextureSize, TextureSize), 0, 0);
        GetComponent<Camera>().targetTexture = null;
        RenderTexture.active = null;
        snapshot.alphaIsTransparency = true;
        byte[] bytes = snapshot.EncodeToPNG();
        DestroyImmediate(rt);
        DestroyImmediate(snapshot);

        string folderPath = $"{Path.GetFullPath(Path.Combine(Application.dataPath, "../"))}/maps/overviews/snapshots";
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);
        string filePath = $"{folderPath}/{SceneManager.GetActiveScene().name}.png";
        File.WriteAllBytes(filePath, bytes);
        snapshotPath = filePath;
        AssetDatabase.Refresh();
    }

    [ContextMenu("Generate Overview")]
    public void GenerateOverview()
    {
        RectTransform rectTr = GetComponent<RectTransform>();
        OverViewSerialize.OverView overview = new OverViewSerialize.OverView
        {
            Texture = Convert.ToBase64String(File.ReadAllBytes(snapshotPath)),
            PosX = rectTr.position.x,
            PosZ = rectTr.position.z,
            Width = rectTr.sizeDelta.x,
            Height = rectTr.sizeDelta.y
        };
        OverViewSerialize.Save(SceneManager.GetActiveScene().name, overview);
    }

    public void OnDrawGizmosSelected()
    {
        RectTransform r = GetComponent<RectTransform>();
        Vector3 v = r.sizeDelta;
        Vector3 pivot = r.localPosition;

        Gizmos.color = Color.red;
        Gizmos.DrawCube(pivot, new Vector3(v.x, 2, v.y));
        Gizmos.DrawWireCube(pivot, new Vector3(v.x, 2, v.y));
    }

    public void Update()
    {
        RectTransform r = GetComponent<RectTransform>();
        Camera c = GetComponent<Camera>();
        if (r != null && c != null)
        {
            c.orthographicSize = Math.Max(r.sizeDelta.x, r.sizeDelta.y) / 2;
        }
    }

    public void OnEnable()
    {
        Camera c = GetComponent<Camera>();
        if (c != null)
        {
            c.useOcclusionCulling = false;
            c.allowMSAA = false;
            c.orthographic = true;
            c.transform.eulerAngles = new Vector3(90, 0, 0);
        }
        string baseDir = $"{Path.GetFullPath(Path.Combine(Application.dataPath, "../"))}/overviews/snapshots/";
        if (Directory.Exists(baseDir))
            Directory.CreateDirectory(baseDir);
    }
}
#endif