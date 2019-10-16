using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Constants;
using GetPanelHierarchy;
using UnityEngine.UI;

public class ChildInParentSpriteDrag : MonoBehaviour
{
    
    [SerializeField, ShowOnly] private bool isDraging;
    [SerializeField, ShowOnly] private bool isExitChildBackSprite;
    private SpriteRenderer spriteRenderer;
    private Vector2 defaultPanelPosition = new Vector2(-64, -112);
    private void OnMouseDrag()
    {
        if (spriteRenderer.sprite == null)
        {
            return;
        }

        if (!isDraging)
        {
            OnDragStart();
        }
        isDraging = true;
        Vector2 objectPointInScreen
            = Camera.main.WorldToScreenPoint(this.transform.position);

        Vector3 mousePointInScreen
            = new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,Value.cameraZ);
        
        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        mousePointInWorld.z = Value.childInParentPositionZ;
        this.transform.position = mousePointInWorld;
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
            GameObject parent = this.gameObject.GetComponent<ChildInParentOwnParentObject>().parentObj;
            parent.SetActive(true);
            parent.transform.localPosition = this.gameObject.transform.localPosition;
            this.gameObject.transform.position = defaultPanelPosition;

            spriteRenderer.sprite = null;
            isExitChildBackSprite = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject == SerializeObject.Instance.GetParentsBackSprite)
        {
            isExitChildBackSprite = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == SerializeObject.Instance.GetParentsBackSprite)
        {
            isExitChildBackSprite = false;
        }
    }

    private void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }
}
