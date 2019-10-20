using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var t = typeof(T);

                instance = (T) FindObjectOfType(t);
                if (instance == null)
                {
                    Debug.LogError(t + " をアタッチしているGameObjectはありません");
                }
            }

            return instance;
        }
    }

    protected virtual void Awake()
    {
        // 他のゲームオブジェクトにアタッチされているか調べる
        // アタッチされている場合は破棄する。
        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if (instance == null)
        {
            instance = this as T;
            return true;
        }

        if (Instance == this)
        {
            return true;
        }

        Debug.Log("Accurate. " + GetType().Name + "型のオブジェクトは既に存在します。古いオブジェクトを削除します");
        Destroy(gameObject);
        return false;
    }
}