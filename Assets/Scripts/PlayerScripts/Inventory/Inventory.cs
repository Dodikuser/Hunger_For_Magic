using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : IInventory
{
    public Dictionary<string, Amulet> Amulets = new Dictionary<string, Amulet>();
    public Dictionary<Element, int> AvailableElements = new Dictionary<Element, int>();

    public void AddElement(Element element, int count = 1)
    {
        if (AvailableElements.ContainsKey(element)) AvailableElements[element] += count;
        else AvailableElements.Add(element, count);     
    }

    public void SubtractElement(Element element, int count = 1)
    {
        if (AvailableElements.ContainsKey(element))
        {
            AvailableElements[element] -= count;
            if (AvailableElements[element] <= 0) AvailableElements.Remove(element);
        }
        else Debug.LogWarning($"Cannot find element {element} in inventory");    
    }

    public void RemoveElement(Element element)
    {
        AvailableElements.Remove(element);
    }
}
