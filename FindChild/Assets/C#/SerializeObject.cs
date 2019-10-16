using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeObject : SingletonMonoBehaviour<SerializeObject>
{
    [SerializeField] private GameObject childPanelsRoot;
    [SerializeField] private GameObject parentsRoot;
    [SerializeField] private GameObject mainCanvasRoot;
    [SerializeField] private GameObject parentsBackSprite;
    [SerializeField] private GameObject speechBubbleText;

    public GameObject GetChildPanelsRoot
    {
        get { return childPanelsRoot; }
    }

    public GameObject GetParentsRoot
    {
        get { return parentsRoot; }
    }

    public GameObject GetMainCanvasRoot
    {
        get { return mainCanvasRoot; }
    }

    public GameObject GetParentsBackSprite
    {
        get { return parentsBackSprite; }
    }

    public GameObject GetSpeechBubbleText
    {
        get { return speechBubbleText; }
    }
}
