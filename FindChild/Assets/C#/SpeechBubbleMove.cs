using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbleMove : MonoBehaviour
{
    public GameObject parent;
    
    private void FixedUpdate()
    {
        ChangeSpeechBubblePosition();
    }

    public void ChangeSpeechBubblePosition()
    {
        if (parent != null)
        {
            Vector2 speechBubbleLeftUp =
                new Vector2(parent.transform.position.x,
                    parent.transform.position.y);
            this.gameObject.transform.position = Camera.main.WorldToScreenPoint(speechBubbleLeftUp);
        }
    }
}
