using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ElementContainer;

public struct Element
{
    public TypesElements Type;
    public Dictionary<TypesElements, float> DamageFactor;

    public Element(TypesElements type, Dictionary<TypesElements, float> DamageFactors)
    {
        this.Type = type;
        this.DamageFactor = DamageFactors;
    }   
    public float GiveFactor(TypesElements type)
    {
        return DamageFactor[type];
    }
}
