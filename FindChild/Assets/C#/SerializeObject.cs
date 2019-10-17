using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeObject : SingletonMonoBehaviour<SerializeObject>
{
    [SerializeField] private GameObject childPanelsRoot;
    [SerializeField] private GameObject parentsRoot;
    [SerializeField] private GameObject childWordText;
    [SerializeField] private GameObject parentsBackSprite;
    [SerializeField] private GameObject speechBubbleText;
    [SerializeField] private GameObject speechBubbleSprite;

    public GameObject GetChildPanelsRoot
    {
        get { return childPanelsRoot; }
    }

    public GameObject GetParentsRoot
    {
        get { return parentsRoot; }
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
}
