using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeObject : SingletonMonoBehaviour<SerializeObject>
{
    [SerializeField] private GameObject childPanelsRoot;
    [SerializeField] private GameObject parentsRoot;

    public GameObject GetChildPanelsRoot
    {
        get { return childPanelsRoot; }
    }

    public GameObject GetParentsRoot
    {
        get { return parentsRoot; }
    }
}
