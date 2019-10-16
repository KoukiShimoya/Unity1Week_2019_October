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
    private Vector3 defaultPanelPosition = new Vector3(-64, -112, Value.childInParentPositionZ);
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
            SerializeObject.Instance.GetSpeechBubbleText.SetActive(true);
            parent.transform.position = this.gameObject.transform.position;
            parent.transform.GetChild(0).GetComponent<ParentSpriteDrag>().SpeechTextMove();
            this.gameObject.transform.localPosition = defaultPanelPosition;

            spriteRenderer.sprite = null;
            isExitChildBackSprite = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
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
