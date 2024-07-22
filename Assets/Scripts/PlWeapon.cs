using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlWeapon : MonoBehaviour, IPLWeapon
{
    public IElement Element { get; private set; }
    public float Damage { get; private set; }
    public IPLWeapon.TypeDamage WeaponTypeDamage { get; private set; }

    public void ElementCange(string name)
    {
        Element.Name = name;
    }

    public void Fire(Enemy enemy)
    {
        
    }
}
