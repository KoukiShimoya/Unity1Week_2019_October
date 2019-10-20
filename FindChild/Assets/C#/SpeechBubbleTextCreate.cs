using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChildrenAttribute;
using Constants;
using UnityEngine.UI;

public static class SpeechBubbleTextCreate
{
    // Start is called before the first frame update
    public static string ChildAttributeToText_Child(ChildAttribute childAttribute)
    {
        string bubbleText = "";
        
        /*
        if (childAttribute.capAttribute.understanding)
        {
            bubbleText += "帽子は" + childAttribute.capAttribute.hasCap;
        }

        if (childAttribute.sexAttribute.understanding)
        {
            if (addNewLine)
            {
                bubbleText = AddNewLine(bubbleText);
            }
            else
            {
                bubbleText = AddComma(bubbleText);
            }
            bubbleText += "性別は" + childAttribute.sexAttribute.sexType.ToString();
        }
        */

        if (childAttribute.ageAttribute.understanding)
        {
            bubbleText += "年は" + childAttribute.ageAttribute.age.ToString() + "歳です。";
        }

        if (childAttribute.nameAttribute.understanding)
        {
            bubbleText += "名前は" + childAttribute.nameAttribute.name + "です。";
        }

        if (bubbleText == Word.empty)
        {
            bubbleText = "うわぁーーーん。";
        }

        return bubbleText;
    }
    
    public static string ChildAttributeToText_Parent(ChildAttribute childAttribute)
    {
        string bubbleText = "";
        
        if (childAttribute.capAttribute.understanding)
        {
            if (childAttribute.capAttribute.hasCap)
            {
                bubbleText += "帽子をつけています。";
            }
            else
            {
                bubbleText += "帽子はつけていないです。";
            }
        }

        if (childAttribute.sexAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);

            if (childAttribute.sexAttribute.sexType == SexType.Male)
            {
                bubbleText += "男の子です。";
            }
            else if (childAttribute.sexAttribute.sexType == SexType.Female)
            {
                bubbleText += "女の子です。";
            }
        }

        if (childAttribute.ageAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);
            
            bubbleText += "年は" + childAttribute.ageAttribute.age.ToString() +"歳です。";
        }

        if (childAttribute.nameAttribute.understanding)
        {
            bubbleText = AddNewLine(bubbleText);
            
            bubbleText += "名前は" + childAttribute.nameAttribute.name + "です。";
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

    private static string AddComma(string str)
    {
        if (str == Word.empty)
        {
            return str;
        }
        else
        {
            return str + Word.comma + Word.blank;
        }
    }
}