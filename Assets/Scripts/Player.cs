using UnityEngine;

public class Player : Entity, ICombatable, IChanger, IInventory
{
    public Enemy SelectedEnemy;
    public Part SelectedPart;
    public PlWeapon PLWeapon;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            DealDamage(SelectedPart);
        }
    }
    public void DealDamage(Entity entity)
    {
        PLWeapon.DealDamage(entity);
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

    public void SetPart(Part patr)
    {
        SelectedPart = patr;
    }

}
