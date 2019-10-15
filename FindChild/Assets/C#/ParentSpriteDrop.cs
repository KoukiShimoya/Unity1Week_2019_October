using System.Collections;
using System.Collections.Generic;
using GetPanelHierarchy;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ParentSpriteDrop : MonoBehaviour
{
    public void OnDrop(BaseEventData data)
    {
        Debug.Log("Drop");
        PointerEventData pointerEventData = (PointerEventData) data;
        ChildPanel.ChildSprite_ChildInParentSprite(this.gameObject).GetComponent<Image>().sprite = GetPanelHierarchy
            .ParentSprite.Parent_ParentSprite(pointerEventData.pointerDrag).GetComponent<Image>().sprite;
    }
}
