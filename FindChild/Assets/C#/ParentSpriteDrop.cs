using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ParentSpriteDrop : MonoBehaviour
{
    public void OnDrop(BaseEventData data)
    {
        PointerEventData pointerEventData = (PointerEventData) data;
        Debug.Log(pointerEventData.pointerDrag.gameObject);
        /*
        Debug.Log(pointerEventData.pointerEnter);
        this.gameObject.GetComponent<Image>().sprite = GetPanelHierarchy.ParentSprite
            .Parent_ParentSprite(pointerEventData.pointerEnter).GetComponent<Image>().sprite;
        */
    }
}
