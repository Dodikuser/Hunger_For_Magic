using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int damageAmount);
}

public interface IDealDamage
{
    void DealDamage(IDamageable target, int damageAmount);
}

