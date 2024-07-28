using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : Entity, ITakeDamage, ICanDie, ICangeElement
{
    public Element Element { get; private set; }
    [SerializeField] protected Enemy ParentEnemy;

    public string StartElement;

    private void Awake()
    {
        ResetHealth();
        SetElement(StartElement);
    }

    public override string ToString()
    {
        return "DefaultPart";
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        if (CurrentHealth <= 0) Die();
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
