using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Constants;
using GetPanelHierarchy;
using UnityEngine.UI;

public class ChildInParentSpriteDrag : MonoBehaviour
{
    private GameObject parentObject;
    private RectTransform rectTransform;
    
    public void OnDrag()
    {
        if (parentObject != null)
        {
            rectTransform.localPosition =
                UIChangePosition.UIChangeToMousePosition(SerializeObject.Instance.GetMainCanvasRectTransform,
                    rectTransform, 1);
        }
    }

    public void OnBeginDrag()
    {
        parentObject = this.gameObject.GetComponent<ChildInParentOwnParentObject>().parentObj;
    }

    public void OnEndDrag()
    {
        if (UIChangePosition.CheckOverlap(rectTransform,
            SerializeObject.Instance.GetParentBackSprite.GetComponent<RectTransform>()))
        {
            Debug.Log("ChildInParentEndDrag");
            parentObject.SetActive(true);
            parentObject.transform.localPosition = this.gameObject.transform.localPosition;
            rectTransform.anchoredPosition = Vector2.zero;
            this.gameObject.GetComponent<Image>().sprite = null;
            parentObject = null;
        }
    }

    private void Start()
    {
        rectTransform = this.gameObject.GetComponent<RectTransform>();
    }
}
