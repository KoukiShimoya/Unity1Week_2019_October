using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Constants;

public class ParentSpriteDrag : MonoBehaviour
{
    [SerializeField] private RectTransform canvasRect;
    private RectTransform rectTransform;
    [SerializeField] private RectTransform targetRect;

    private void Start()
    {
        rectTransform = this.gameObject.GetComponent<RectTransform>();
    }
    public void OnDrag()
    {
        Vector2 position = Input.mousePosition;
        Vector2 screenPoint = Camera.main.ScreenToViewportPoint(position);
        
        Vector2 worldObjectToScreenPosition = new Vector2(
            ((screenPoint.x * canvasRect.sizeDelta.x) - (canvasRect.sizeDelta.x * 0.5f)),
            ((screenPoint.y * canvasRect.sizeDelta.y) - (canvasRect.sizeDelta.y * 0.5f)));
        
        rectTransform.anchoredPosition = worldObjectToScreenPosition;
    }
    
    private bool CheckOverlap(RectTransform rectTrans1, RectTransform rectTrans2)
    {
        Rect rect1 = new Rect(rectTrans1.localPosition.x, rectTrans1.localPosition.y, rectTrans1.rect.width, rectTrans1.rect.height);
        Rect rect2 = new Rect(rectTrans2.localPosition.x, rectTrans2.localPosition.y, rectTrans2.rect.width, rectTrans2.rect.height);

        return rect1.Overlaps(rect2);
    }

    public void EndDrag()
    {
        GameObject[] childPanels = SerializeObject.Instance.GetChildPanelsRoot.GetOnlyOwnChildren();
        foreach (var childPanel in childPanels)
        {
            if (CheckOverlap(rectTransform, childPanel.GetComponent<RectTransform>()))
            {
                if (Useful.isSameChildAttributeValue(childPanel.GetComponent<OneChildAttribute>().childAttribute, this.gameObject.GetComponent<OneChildAttribute>().childAttribute))
                {
                    GetPanelHierarchy.ChildPanel.ChildPanel_ChildSprite(childPanel).GetComponent<Image>().sprite =
                        GetPanelHierarchy.ParentSprite.Parent_ParentSprite(this.gameObject).GetComponent<Image>().sprite;
                }
            }
        }
    }
}
