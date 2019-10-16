using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GetPanelHierarchy;

public class SpeechBubbleSetActive : MonoBehaviour
{
    public void OnPointerDown()
    {
        GameObject speechBubbleSprite = ParentSprite.ParentSprite_SpeechBubbleSprite(this.gameObject);
        speechBubbleSprite.SetActive(!speechBubbleSprite.activeSelf);
    }
}
