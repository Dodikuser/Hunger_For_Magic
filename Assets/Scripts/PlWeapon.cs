using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlWeapon : MonoBehaviour, IDealDamage, ICangeElement
{
    private Element Element { get; set;}
    private float MainDamage { get; set; }

    public void DealDamage(Entity entity)
    {
        Part part = entity as Part;
        if (part != null) return;

        float damage;
        if (Element.Type != Element.TypesElements.None)
             damage = MainDamage * 0;  
        else damage = MainDamage;

        part.TakeDamage(damage);
    }

    public void ResetElement()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeElement()
    {
        throw new System.NotImplementedException();
    }
}
