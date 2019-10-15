using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GetPanelHierarchy;
using ChildrenAttribute;
using Constants;
using UnityEngine.UI;

public class SpeechBubbleTextCreate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject parent = ParentSprite.SpeechBubbleText_Parent(this.gameObject);
        ChildAttribute childAttribute = parent.GetComponent<OneChildAttribute>().childAttribute;

        string bubbleText = "";
        
        if (childAttribute.hairAttribute.understanding)
        {
            bubbleText += "髪型は" + childAttribute.hairAttribute.hairType.ToString();
        }

        if (childAttribute.sexAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);
            bubbleText += "性別は" + childAttribute.sexAttribute.sexType.ToString();
        }

        if (childAttribute.ageAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);
            bubbleText += "年齢は" + childAttribute.ageAttribute.age.ToString();
        }

        if (childAttribute.nameAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);
            bubbleText += "名前は" + childAttribute.nameAttribute.name;
        }

        if (childAttribute.shirtAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);
            bubbleText += "シャツの色は" + childAttribute.shirtAttribute.shirtType.ToString();
        }

        this.gameObject.GetComponent<Text>().text = bubbleText;
    }

    private string AddNewLine(string str)
    {
        if (str == Word.empty)
        {
            return str;
        }
        else
        {
            return str + Word.crlf;
        }
    }
}
