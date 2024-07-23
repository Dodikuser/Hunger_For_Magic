using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ITakeDamage
{
    public int maxHealth = 50;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Πεΰλ³ηΰφ³ÿ IDamageable
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log(name + " took damage: " + damageAmount + ", Current Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log(name + " has died.");
        Destroy(gameObject);
    }
}
