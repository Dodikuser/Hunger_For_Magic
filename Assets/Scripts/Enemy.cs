using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity, ITakeDamage, ICanDie
{
    [SerializeField] protected List<Part> PartList = new List<Part>();
    [SerializeField] protected Dictionary<string, Part> Parts = new Dictionary<string, Part>();

    private void Awake()
    {
        CurrentHealth = MaxHealth;

        for (int i = 0; i < PartList.Count; i++)
        {        
            Parts.Add(PartList[i].ToString(), PartList[i]);
        }
    }
    void Start()
    {
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
