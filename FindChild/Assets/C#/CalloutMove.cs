using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalloutMove : MonoBehaviour
{
    RectTransform rectTransform;
    private void Start()
    {
        rectTransform = this.gameObject.GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (rectTransform.anchoredPosition.y > 1080)
        {
            Destroy(this.gameObject);
        }
        rectTransform.anchoredPosition =
            new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y + 7);
    }
}
