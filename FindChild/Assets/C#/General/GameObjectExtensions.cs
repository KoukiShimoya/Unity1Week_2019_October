using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class GameObjectExtensions
{
    /// <summary>
    ///     すべての子オブジェクトを返します
    /// </summary>
    /// <param name="self">GameObject 型のインスタンス</param>
    /// <param name="includeInactive">非アクティブなオブジェクトも取得する場合 true</param>
    /// <returns>すべての子オブジェクトを管理する配列</returns>
    public static GameObject[] GetChildren(this GameObject self, bool includeInactive = false)
    {
        return self.GetComponentsInChildren<Transform>(includeInactive)
            .Where(c => c != self.transform)
            .Select(c => c.gameObject)
            .ToArray();
    }

    //自作：自身の直下の子オブジェクトのみを返す
    public static GameObject[] GetOnlyOwnChildren(this GameObject go)
    {
        var returnGo = new GameObject[go.transform.childCount];
        for (var i = 0; i < returnGo.Length; i++)
        {
            returnGo[i] = go.transform.GetChild(i).gameObject;
        }

        return returnGo;
    }

    // 追記術：自身が親オブジェクトの中で何番目かどうか
    public static int WhichNumber(GameObject own, List<GameObject> childs)
    {
        var i = 0;
        foreach (var go in childs)
        {
            if (go == own)
            {
                return i;
            }

            i++;
        }

        Debug.Log("Error! GameObjectExtensions.WhichNumber does not have same object. Return -1.");
        return -1;
    }

    /// <summary>
    ///     指定されたコンポーネントがアタッチされているかどうかを返します
    /// </summary>
    public static bool HasComponent<T>(this GameObject self) where T : Component
    {
        return self.GetComponent<T>() != null;
    }


    //copy by http://baba-s.hatenablog.com/entry/2014/07/29/082441
    //copy by http://baba-s.hatenablog.com/entry/2014/07/14/101855
}