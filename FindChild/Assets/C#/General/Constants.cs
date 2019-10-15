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
            if (childAttribute0.hairAttribute.hairType != childAttribute1.hairAttribute.hairType)
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

            if (childAttribute0.shirtAttribute.shirtType != childAttribute1.shirtAttribute.shirtType)
            {
                return false;
            }

            return true;
        }
    }
}
