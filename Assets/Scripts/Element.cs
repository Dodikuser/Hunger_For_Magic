using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Element
{
    public enum TypesElements
    {
        None,
        Fire,
        Water,
        Ground,
        Air,
    }

    public TypesElements Type;
    public Dictionary<TypesElements, float> DamageFactor;

    public Element(TypesElements type, Dictionary<TypesElements, float> DamageFactors)
    {
        this.Type = type;
        this.DamageFactor = DamageFactors;
    }   
}
