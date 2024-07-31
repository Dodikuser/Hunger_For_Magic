using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlWeapon : MonoBehaviour, IDealDamage, ICangeElement
{
    [SerializeField] private Element Element;
    [SerializeField] private float MainDamage;

    public string StartElement;

    private void Awake()
    {  
    }
    private void Start()
    {
        SetElement(StartElement);   
    }

    public void DealDamage(Entity entity)
    {

        Part part = entity as Part;
        if (part == null) return;

        float damage;
        if (Element.Type != ElementContainer.TypesElements.None)
             damage = MainDamage * Element.GiveFactor(part.Element.Type);  
        else damage = MainDamage;

        part.TakeDamage(damage);

        ResetElement();
    }

    public void ResetElement()
    {
        Element = ElementContainer.Elements["None"];
    }

    public void SetElement(string name)
    {
        try
        {
            Element = ElementContainer.Elements[name];
        }
        catch
        {
            Element = ElementContainer.Elements["None"];
            Debug.LogWarning($"The {ToString()} has no element");
        }
    }
}
