using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChildrenAttribute
{
    [System.Serializable]
    public class ChildAttribute
    {
        public CapAttribute capAttribute;
        public SexAttribute sexAttribute;
        public AgeAttribute ageAttribute;
        public NameAttribute nameAttribute;

        public ChildAttribute(CapAttribute capAttribute, SexAttribute sexAttribute, AgeAttribute ageAttribute,
            NameAttribute nameAttribute)
        {
            this.capAttribute = capAttribute;
            this.sexAttribute = sexAttribute;
            this.ageAttribute = ageAttribute;
            this.nameAttribute = nameAttribute;
        }
    }

    [System.Serializable]
    public class CapAttribute
    {
        public bool hasCap;
        public bool understanding;

        public CapAttribute(bool hasCap, bool understanding)
        {
            this.hasCap = hasCap;
            this.understanding = understanding;
        }
    }
    
    [System.Serializable]
    public class SexAttribute
    {
        public SexType sexType;
        public bool understanding;

        public SexAttribute(SexType sexType, bool understanding)
        {
            this.sexType = sexType;
            this.understanding = understanding;
        }
    }
    
    [System.Serializable]
    public class AgeAttribute
    {
        public int age;
        public bool understanding;

        public AgeAttribute(int age, bool understanding)
        {
            this.age = age;
            this.understanding = understanding;
        }
    }
    
    [System.Serializable]
    public class NameAttribute
    {
        public string name;
        public bool understanding;

        public NameAttribute(string name, bool understanding)
        {
            this.name = name;
            this.understanding = understanding;
        }
    }

    public enum SexType
    {
        Male,
        Female
    }

    public enum ShirtType
    {
        TShirt
    }
}
