using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public float HP { get; private set; }
    public IPLWeapon Weapon { get; private set; }

    public void Attack()
    {
        Weapon.Fire();
    }

    public void TakeDamage(float damage)
    {
       
    }
}
