using UnityEngine;

public class Player : Entity, ICombatable, IChanger, IInventory
{
    public void DealDamage(Entity entity)
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(float damage)
    {
        Hp -= damage;
    }

    public void ChangeWeapon()
    {
        throw new System.NotImplementedException();
    }

    public void Change—harm()
    {
        throw new System.NotImplementedException();
    }

    public void AddElement()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveElement()
    {
        throw new System.NotImplementedException();
    }
    
}
