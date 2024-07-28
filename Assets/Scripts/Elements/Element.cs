using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ElementContainer;

public struct Element
{
    public TypesElements Type;
    public Dictionary<TypesElements, float> DamageFactor;
    public Sprite Icon;

    public Element(TypesElements type, Sprite icon, Dictionary<TypesElements, float> DamageFactors)
    {
        this.Type = type;
        this.DamageFactor = DamageFactors;
        this.Icon = icon;
    }   
    public float GiveFactor(TypesElements type)
    {
        return DamageFactor[type];
    }
    public override string ToString()
    {
        return Type.ToString();
    }
}
