using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildInParentOwnParentObject : MonoBehaviour
{
    [ShowOnly] public GameObject parentObj;

    private void Start()
    {
        parentObj = null;
    }
}
