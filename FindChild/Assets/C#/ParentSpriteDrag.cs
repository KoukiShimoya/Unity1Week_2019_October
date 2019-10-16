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
    [SerializeField, ShowOnly] private bool isDraging;
    [SerializeField, ShowOnly] private bool isExitChildBackSprite;
    [SerializeField, ShowOnly] private GameObject enterChildBackSprite;

    private void OnMouseDrag()
    {
        if (!isDraging)
        {
            OnDragStart();
        }
        isDraging = true;
        Vector2 objectPointInScreen
            = Camera.main.WorldToScreenPoint(this.transform.parent.transform.position);

        Vector3 mousePointInScreen
            = new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,Value.cameraZ);
        
        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        mousePointInWorld.z = 0;
        this.gameObject.transform.parent.transform.position = mousePointInWorld;
    }

    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
        if (isDraging)
        {
            OnDragEnd();
            isDraging = false;
        }
    }

    private void OnDragStart()
    {
        
    }

    private void OnDragEnd()
    {
        if (isExitChildBackSprite)
        {
            enterChildBackSprite.transform.parent.GetChild(3).GetComponent<SpriteRenderer>().sprite =
                GetComponent<SpriteRenderer>().sprite;
            enterChildBackSprite.transform.parent.GetChild(3).GetComponent<ChildInParentOwnParentObject>().parentObj =
                this.gameObject.transform.parent.gameObject;
            this.gameObject.transform.parent.gameObject.SetActive(false);
            isExitChildBackSprite = false;
            enterChildBackSprite = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Value.childBackSprite))
        {
            isExitChildBackSprite = true;
            enterChildBackSprite = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Value.childBackSprite))
        {
            isExitChildBackSprite = false;
            enterChildBackSprite = null;
        }
    }
}
