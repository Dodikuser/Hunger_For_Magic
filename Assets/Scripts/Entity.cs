using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Entity : MonoBehaviour, ITakeDamage
{
    public float MaxHealth;
    protected float CurrentHealth { get; set; }

    private void Awake()
    {
        ResetHealth();
    }

    public virtual void TakeDamage(float damage)
    {
        Debug.Log($"{ToString()}: I Take {damage} damage");
        CurrentHealth -= damage;
    }
    public void ResetHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
