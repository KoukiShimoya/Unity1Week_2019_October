using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChildrenAttribute;

namespace Constants
{
    public static class Word
    {
        public static string empty = "";
        public static char crlf = '\n';
    }

    public static class Useful
    {
        public static bool isSameChildAttributeValue(ChildAttribute childAttribute0, ChildAttribute childAttribute1)
        {
            if (childAttribute0.capAttribute != childAttribute1.capAttribute)
            {
                return false;
            }

            if (childAttribute0.sexAttribute.sexType != childAttribute1.sexAttribute.sexType)
            {
                return false;
            }

            if (childAttribute0.ageAttribute.age != childAttribute1.ageAttribute.age)
            {
                return false;
            }

            if (childAttribute0.nameAttribute.name != childAttribute1.nameAttribute.name)
            {
                return false;
            }

            return true;
        }
    }

    public static class UIChangePosition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="canvasRect">動かすスプライトが存在するCanvas</param>
        /// <param name="spriteRect">動かすスプライトのRectTransform</param>
        /// <param name="panelNumber">親なら0, 子の内部の親なら1</param>
        /// <returns></returns>
        public static Vector2 UIChangeToMousePosition(RectTransform canvasRect, RectTransform spriteRect, int panelNumber)
        {
            Vector2 position = Input.mousePosition;
            Vector2 screenPoint = Camera.main.ScreenToViewportPoint(position);

            float x = screenPoint.x * canvasRect.sizeDelta.x;
            float y = Mathf.Abs(screenPoint.y - 1);
            y *= -canvasRect.sizeDelta.y;

            //pivotによるズレが発生...
            if (panelNumber == 0)
            {
                x -= 850;
                y += 700;
            }
            else if (panelNumber == 1)
            {
                x -= spriteRect.sizeDelta.x * 0.5f;
                y += spriteRect.sizeDelta.y * 0.5f - 32;
            }
            
            return new Vector2(x, y);
            
            
            /*
             return  new Vector2(
                    ((screenPoint.x * canvasRect.sizeDelta.x) - (canvasRect.sizeDelta.x * 0.5f)),
                    ((screenPoint.y * canvasRect.sizeDelta.y) - (canvasRect.sizeDelta.y * 0.5f)));
                    */
        }
        
        public static bool CheckOverlap(RectTransform rectTrans1, RectTransform rectTrans2)
        {
            Rect rect1 = new Rect(rectTrans1.localPosition.x, rectTrans1.localPosition.y, rectTrans1.rect.width, rectTrans1.rect.height);
            Rect rect2 = new Rect(rectTrans2.localPosition.x, rectTrans2.localPosition.y, rectTrans2.rect.width, rectTrans2.rect.height);
            Debug.Log(rectTrans1.localPosition.x + ", " + rectTrans1.localPosition.y + ", " + rectTrans1.rect.width + ", " + rectTrans1.rect.height);
            Debug.Log(rectTrans2.localPosition.x + ", " + rectTrans2.localPosition.y + ", " + rectTrans2.rect.width + ", " + rectTrans2.rect.height);
            return rect1.Overlaps(rect2);
        }
    }
}
