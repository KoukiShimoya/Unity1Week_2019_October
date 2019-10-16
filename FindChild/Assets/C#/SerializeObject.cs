﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeObject : SingletonMonoBehaviour<SerializeObject>
{
    [SerializeField] private GameObject childPanelsRoot;
    [SerializeField] private GameObject parentsRoot;
    [SerializeField] private GameObject mainCanvasRoot;
    [HideInInspector] private RectTransform mainCanvasRectTransform;
    [SerializeField] private GameObject parentBackSprite;

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

    public GameObject GetParentBackSprite
    {
        get { return parentBackSprite; }
    }

    public RectTransform GetMainCanvasRectTransform
    {
        get { return mainCanvasRectTransform; }
    }

    private void Start()
    {
        mainCanvasRectTransform = mainCanvasRoot.GetComponent<RectTransform>();
    }
}
