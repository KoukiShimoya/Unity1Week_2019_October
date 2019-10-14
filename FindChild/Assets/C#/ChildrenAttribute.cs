using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChildrenAttribute
{
    [System.Serializable]
    public class ChildAttribute
    {
        public HairAttribute hairAttribute;
        public SexAttribute sexAttribute;
        public AgeAttribute ageAttribute;
        public NameAttribute nameAttribute;
        public ShirtAttribute shirtAttribute;

        public ChildAttribute(HairAttribute hairAttribute, SexAttribute sexAttribute, AgeAttribute ageAttribute,
            NameAttribute nameAttribute, ShirtAttribute shirtAttribute)
        {
            this.hairAttribute = hairAttribute;
            this.sexAttribute = sexAttribute;
            this.ageAttribute = ageAttribute;
            this.nameAttribute = nameAttribute;
            this.shirtAttribute = shirtAttribute;
        }
    }

    [System.Serializable]
    public class HairAttribute
    {
        public HairType hairType;
        public bool understanding;

        public HairAttribute(HairType hairType, bool understanding)
        {
            this.hairType = hairType;
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
    
    [System.Serializable]
    public class ShirtAttribute
    {
        public ShirtType shirtType;
        public bool understanding;

        public ShirtAttribute(ShirtType shirtType, bool understanding)
        {
            this.shirtType = shirtType;
            this.understanding = understanding;
        }
    }

    public enum HairType
    {
        Long
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
