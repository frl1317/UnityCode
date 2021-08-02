using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ShortcutTools : Editor
{
    [MenuItem("Tools/快捷键/切换选中物体显隐状态 &q")]
    public static void SetObjActive()
    {
        GameObject[] selectObjs = Selection.gameObjects;
        int objCtn = selectObjs.Length;
        for (int i = 0; i < objCtn; i++)
        {
            bool isAcitve = selectObjs[i].activeSelf;
            selectObjs[i].SetActive(!isAcitve);
        }
    }

    [MenuItem("Tools/快捷键/保存选中ui &s")]
    public static void SaveSelectPrefab()
    {
        GameObject[] selectObjs = Selection.gameObjects;
        int objCtn = selectObjs.Length;
        for (int i = 0; i < objCtn; i++)
        {
            string prefabPath = UnityEditor.PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(selectObjs[i].transform.root);
            if(string.IsNullOrEmpty(prefabPath))
            {
                Debug.LogWarning("Tools/通用工具/保存选中ui-----选中的物体不是预制体");
                continue;
            }

            PrefabUtility.ApplyPrefabInstance(selectObjs[i].transform.root.gameObject, InteractionMode.AutomatedAction);
            Debug.Log("Tools/通用工具/保存选中ui-----保存预设:"+ prefabPath);
        }
    }
}
