using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildPanelClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        SerializeObject.Instance.GetChildWordText.GetComponent<Text>().text =
            SpeechBubbleTextCreate.ChildAttributeToText_Child(this.gameObject.transform.parent
                .GetComponent<OneChildAttribute>().childAttribute);
    }
}
