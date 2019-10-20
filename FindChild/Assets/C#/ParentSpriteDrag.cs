using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Constants;

public class ParentSpriteDrag : MonoBehaviour
{
    [SerializeField, ShowOnly] private bool isDraging;
    [SerializeField, ShowOnly] private bool isExitChildBackSprite;
    [SerializeField, ShowOnly] private GameObject enterChildBackSprite;
    private float mouseDargTime = 0f;

    private void OnMouseDrag()
    {
        if (!isDraging)
        {
            OnDragStart();
        }
        
        mouseDargTime += Time.deltaTime;
        if (mouseDargTime < Value.mouseDragTime)
        {
            return;
        }
        
        Vector2 objectPointInScreen
            = Camera.main.WorldToScreenPoint(this.transform.parent.transform.position);

        Vector3 mousePointInScreen
            = new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,Value.cameraZ);
        
        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        mousePointInWorld.z = 0;
        this.gameObject.transform.parent.transform.position = mousePointInWorld;
        
        GameObject speechBubble = SerializeObject.Instance.GetSpeechBubbleSprite;
        speechBubble.GetComponent<SpeechBubbleMove>().parent = this.gameObject;
    }

    private void OnMouseDown()
    {
        GameObject speechBubble = SerializeObject.Instance.GetSpeechBubbleSprite;
        GameObject speechTextUI = SerializeObject.Instance.GetSpeechBubbleText;
        if (!speechBubble.activeSelf)
        {
            speechBubble.SetActive(true);
            speechBubble.GetComponent<SpeechBubbleMove>().parent = this.gameObject;
            speechBubble.GetComponent<SpeechBubbleMove>().ChangeSpeechBubblePosition();
            speechTextUI.GetComponent<Text>().text =
                SpeechBubbleTextCreate.ChildAttributeToText(this.gameObject.transform.parent
                    .GetComponent<OneChildAttribute>().childAttribute, true);
        }
        else
        {
            speechBubble.SetActive(false);
            speechBubble.GetComponent<SpeechBubbleMove>().parent = null;
        }
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
        mouseDargTime = 0f;
        isDraging = true;
    }

    private void OnDragEnd()
    {
        if (isExitChildBackSprite)
        {
            SpriteRenderer childInParenetSpriteRenderer =
                enterChildBackSprite.transform.parent.GetChild(3).GetComponent<SpriteRenderer>();
            ChildInParentOwnParentObject cipopo = enterChildBackSprite.transform.parent.GetChild(3)
                .GetComponent<ChildInParentOwnParentObject>();
            
            if (childInParenetSpriteRenderer.sprite == null && cipopo.parentObj == null)
            {
                childInParenetSpriteRenderer.sprite = GetComponent<SpriteRenderer>().sprite;
                cipopo.parentObj = this.gameObject.transform.parent.gameObject;
                this.gameObject.transform.parent.gameObject.SetActive(false);
                
                GameObject speechBubble = SerializeObject.Instance.GetSpeechBubbleSprite;
                speechBubble.SetActive(false);
                speechBubble.GetComponent<SpeechBubbleMove>().parent = null;
            
                isExitChildBackSprite = false;
                enterChildBackSprite = null;
            }
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
