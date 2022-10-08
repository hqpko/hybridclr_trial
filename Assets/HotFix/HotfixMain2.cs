using UnityEngine;

public class HotfixMain2
{
    public static void Start(byte[] abData)
    {
        var assetBundle = AssetBundle.LoadFromMemory(abData);

        var testPrefab = GameObject.Instantiate(assetBundle.LoadAsset<GameObject>("HotUpdatePrefab.prefab"));
        var com1 = testPrefab.GetComponent<HotifxMain>();
        Debug.Log($"GetComponent<T>获取组件是否成功:{com1 != null}");

        var com2 = testPrefab.GetComponent(typeof(HotifxMain));
        Debug.Log($"GetComponent(typeof(className))获取组件是否成功:{com2 != null}");
        
        var com3 = testPrefab.GetComponent("HotifxMain");
        Debug.Log($"GetComponent(name)获取组件是否成功:{com3 != null}");
    }
}