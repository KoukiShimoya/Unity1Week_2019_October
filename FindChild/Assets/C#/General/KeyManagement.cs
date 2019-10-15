using System.Collections.Generic;
using UnityEngine;

public class KeyManagement : SingletonMonoBehaviour<KeyManagement>
{
    public enum KEYTYPE
    {
        W,
        A,
        S,
        D,
        Q,
        E,
        R,
        Esc,
        Tab,
        Shift,
        Space
    }

    [SerializeField] [ShowOnly] private List<KEYTYPE> keyTypeList;

    public List<KEYTYPE> GetKeyList
    {
        get { return keyTypeList; }
    }

    private void Start()
    {
        keyTypeList = new List<KEYTYPE>();
    }

    private void Update()
    {
        keyTypeList = new List<KEYTYPE>();
        KeyAdd();
    }

    private void KeyAdd()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) /*|| コントローラー時の前移動操作*/)
        {
            keyTypeList.Add(KEYTYPE.W);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            keyTypeList.Add(KEYTYPE.S);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            keyTypeList.Add(KEYTYPE.A);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            keyTypeList.Add(KEYTYPE.D);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            keyTypeList.Add(KEYTYPE.Q);
        }

        if (Input.GetKey(KeyCode.E))
        {
            keyTypeList.Add(KEYTYPE.E);
        }

        if (Input.GetKey(KeyCode.R))
        {
            keyTypeList.Add(KEYTYPE.R);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            keyTypeList.Add(KEYTYPE.Shift);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            keyTypeList.Add(KEYTYPE.Space);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            keyTypeList.Add(KEYTYPE.Esc);
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            keyTypeList.Add(KEYTYPE.Tab);
        }
    }
}