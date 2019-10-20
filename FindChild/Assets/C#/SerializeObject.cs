using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeObject : SingletonMonoBehaviour<SerializeObject>
{
    [SerializeField] private GameObject childPanelsRoot;
    [SerializeField] private GameObject childWordText;
    [SerializeField] private GameObject parentsBackSprite;
    [SerializeField] private GameObject speechBubbleText;
    [SerializeField] private GameObject speechBubbleSprite;
    [SerializeField] private GameObject mainCanvasRoot;
    [SerializeField] private GameObject calloutSprite;

    public GameObject GetChildPanelsRoot
    {
        get { return childPanelsRoot; }
    }

    public GameObject GetChildWordText
    {
        get { return childWordText; }
    }

    public GameObject GetParentsBackSprite
    {
        get { return parentsBackSprite; }
    }

    public GameObject GetSpeechBubbleText
    {
        get { return speechBubbleText; }
    }

    public GameObject GetSpeechBubbleSprite
    {
        get { return speechBubbleSprite; }
    }

    public GameObject GetMainCanvasRoot
    {
        get { return mainCanvasRoot; }
    }

    public GameObject GetCalloutSprite
    {
        get { return calloutSprite; }
    }
}
