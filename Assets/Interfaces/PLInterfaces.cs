using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer
{  
    //public IPLWeapon Weapon { get; set; }

    public void Attack();
    public void TakeDamage(float damage);
}
public interface IPLWeapon
{
    public enum TypeDamage
    {
       Сutting,
       Stabbing,
       Сrushing
    }

    public IElement Element { get; set; }
    public float Damage { get; set; }
    public TypeDamage WeaponTypeDamage { get; set; }

    public void ElementCange();
    public void Fire();
}
public interface IElement
{
    public string Name { get; set; }
    public Dictionary<IElement, int> ElementFactors { get; set; }
}