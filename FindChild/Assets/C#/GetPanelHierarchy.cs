using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetPanelHierarchy
{
    public static class ParentSprite
    {
        public static GameObject SpeechBubbleText_Parent(GameObject speechBubbleText)
        {
            return ParentSprite_Parent(speechBubbleText.transform.parent.gameObject);
        }

        public static GameObject Parent_ParentSprite(GameObject parent)
        {
            return parent.transform.GetChild(0).gameObject;
        }

        public static GameObject ParentSprite_Parent(GameObject parentSprite)
        {
            return parentSprite.transform.parent.gameObject;
        }

        public static GameObject ParentSprite_SpeechBubbleSprite(GameObject parentSprite)
        {
            return Parent_SpeechBubbleSprite(ParentSprite_Parent(parentSprite));
        }

        public static GameObject Parent_SpeechBubbleSprite(GameObject parent)
        {
            return parent.transform.GetChild(1).gameObject;
        }
    }

    public static class ChildPanel
    {
        public static GameObject ChildSprite_ChildInParentSprite(GameObject childSprite)
        {
            return childSprite.transform.parent.GetChild(2).gameObject;
        }

        public static GameObject ChildPanel_ChildSprite(GameObject childPanel)
        {
            return childPanel.transform.GetChild(0).gameObject;
        }

        public static GameObject ChildPanel_ChildInParentSprite(GameObject childSprite)
        {
            return childSprite.transform.GetChild(2).gameObject;
        }
    }
}
