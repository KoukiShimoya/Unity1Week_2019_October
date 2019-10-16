using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Constants;
using GetPanelHierarchy;

public class ParentSpriteDrag : MonoBehaviour
{
    private RectTransform rectTransform;
    private RectTransform spriteRect;
    private RectTransform parentRect;

    private void Start()
    {
        rectTransform = this.gameObject.GetComponent<RectTransform>();
        parentRect = ParentSprite.ParentSprite_Parent(this.gameObject).GetComponent<RectTransform>();
    }

    public void OnDrag()
    {
        rectTransform.localPosition =
            UIChangePosition.UIChangeToMousePosition(SerializeObject.Instance.GetMainCanvasRectTransform, parentRect, 0);
    }

    public void OnBeginDrag()
    {
        spriteRect = this.GetComponent<RectTransform>();
    }

    public void EndDrag()
    {
        GameObject[] childPanels = SerializeObject.Instance.GetChildPanelsRoot.GetOnlyOwnChildren();
        foreach (var childPanel in childPanels)
        {
            if (UIChangePosition.CheckOverlap(rectTransform, childPanel.GetComponent<RectTransform>()))
            {
                GetPanelHierarchy.ChildPanel.ChildPanel_ChildInParentSprite(childPanel).GetComponent<Image>().sprite =
                    GetPanelHierarchy.ParentSprite.Parent_ParentSprite(this.gameObject).GetComponent<Image>().sprite;
                GetPanelHierarchy.ChildPanel.ChildPanel_ChildInParentSprite(childPanel)
                    .GetComponent<ChildInParentOwnParentObject>().parentObj = this.gameObject;
                this.gameObject.SetActive(false);
                /*
                if (Useful.isSameChildAttributeValue(childPanel.GetComponent<OneChildAttribute>().childAttribute, this.gameObject.GetComponent<OneChildAttribute>().childAttribute))
                {
                    GetPanelHierarchy.ChildPanel.ChildPanel_ChildSprite(childPanel).GetComponent<Image>().sprite =
                        GetPanelHierarchy.ParentSprite.Parent_ParentSprite(this.gameObject).GetComponent<Image>().sprite;
                }
                */
            }
        }
    }
}
