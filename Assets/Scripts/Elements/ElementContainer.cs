using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public static class ElementContainer
{
    public enum TypesElements
    {
        None,
        Fire,
        Water,
        Ground,
        Air,
    }

    public static Dictionary<string, Element> Elements = new Dictionary<string, Element>();

    static ElementContainer()
    {
        Element None = new Element(TypesElements.None, Prefabs.Instance.FireIcon, new Dictionary<TypesElements, float>());
        Element Fire = new Element(TypesElements.Fire, Prefabs.Instance.FireIcon, new Dictionary<TypesElements, float>
        {
            { TypesElements.Fire, 1f },
            { TypesElements.Water, 0.5f },
            { TypesElements.Air, 1.5f },
            { TypesElements.Ground, 1f },
        });
        Element Water = new Element(TypesElements.Water, Prefabs.Instance.WaterIcon, new Dictionary<TypesElements, float>
        {
            { TypesElements.Fire, 2f },
            { TypesElements.Water, 1f },
            { TypesElements.Air, 0.2f },
            { TypesElements.Ground, 1f },
        });
        Element Ground = new Element(TypesElements.Ground, Prefabs.Instance.GroundIcon, new Dictionary<TypesElements, float>
        {
            { TypesElements.Fire, 1.5f },
            { TypesElements.Water, 0.5f },
            { TypesElements.Air, 1.5f },
            { TypesElements.Ground, 1f },
        });
        Element Air = new Element(TypesElements.Air, Prefabs.Instance.AirIcon, new Dictionary<TypesElements, float>
        {
            { TypesElements.Fire, 2f },
            { TypesElements.Water, 0.5f },
            { TypesElements.Air, 2f },
            { TypesElements.Ground, 0.5f },
        });

        Elements = new Dictionary<string, Element> {
            {"None", None},
            {"Fire", Fire},
            {"Water", Water},
            {"Ground", Ground},
            {"Air", Air},   
        };
    }

    public static Element GiveElement(string name)
    {
        if (Elements.ContainsKey(name))
            return Elements[name];
        else
        {
            Debug.LogWarning("Invalid element name");
            return Elements["None"];
        }
    }
}
