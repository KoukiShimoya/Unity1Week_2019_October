using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GetPanelHierarchy;
using ChildrenAttribute;
using Constants;
using UnityEngine.UI;

public static class SpeechBubbleTextCreate
{
    // Start is called before the first frame update
    public static string ChildAttributeToText(ChildAttribute childAttribute)
    {
        string bubbleText = "";
        
        if (childAttribute.capAttribute.understanding)
        {
            bubbleText += "帽子は" + childAttribute.capAttribute.hasCap;
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

        return bubbleText;
    }

    private static string AddNewLine(string str)
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