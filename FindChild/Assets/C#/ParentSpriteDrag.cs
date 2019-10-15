using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParentSpriteDrag : MonoBehaviour
{
    [SerializeField] private RectTransform canvasRect;
    private RectTransform rectTransform;

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
}
