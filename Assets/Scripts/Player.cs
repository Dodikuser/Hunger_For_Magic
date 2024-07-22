using UnityEngine;

public class Player : MonoBehaviour, IDamageable, IDealDamage
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Реалізація IDamageable
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("Player took damage: " + damageAmount + ", Current Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Реалізація IDealDamage
    public void DealDamage(IDamageable target, int damageAmount)
    {
        target.TakeDamage(damageAmount);
        Debug.Log("Player dealt damage: " + damageAmount);
    }

    private void Die()
    {
        Debug.Log("Player has died.");
        // Додайте логіку для смерті гравця (наприклад, відновлення, перезапуск гри і т.д.)
    }
}
