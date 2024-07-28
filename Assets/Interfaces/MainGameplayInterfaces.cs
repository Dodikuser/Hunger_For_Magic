using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDealDamage
{
    public void DealDamage(Entity entity);
}
public interface ITakeDamage
{
    public void TakeDamage(float damage);
}
public interface ICombatable: IDealDamage, ITakeDamage
{
}
public interface ICanDie
{
    public void Die();
}
public interface IChanger
{
    public void Change—harm();
    public void ChangeWeapon();
}
public interface IInventory
{
    public void AddElement();
    public void RemoveElement();
}
public interface ICangeElement
{
    public void ResetElement();
    public void SetElement(string name);
}

