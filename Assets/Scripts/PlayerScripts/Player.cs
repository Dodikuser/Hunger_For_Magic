using UnityEngine;

public class Player : Entity, ICombatable, IChanger
{
    public Enemy SelectedEnemy;
    public Part SelectedPart;
    public PlWeapon PLWeapon;
    public Inventory Inventory = new Inventory();

    private void Awake()
    {
        CurrentHealth = MaxHealth;
        Inventory.AddElement(ElementContainer.GiveElement("Fire"));
        Inventory.AddElement(ElementContainer.GiveElement("Water"));
        Inventory.AddElement(ElementContainer.GiveElement("Ground"));
        Inventory.AddElement(ElementContainer.GiveElement("Air"));
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

    public void SetWeapon()
    {
        throw new System.NotImplementedException();
    }

    public void SetAmulet()
    {
        throw new System.NotImplementedException();
    }   

    public void SelectPart(string name)
    {
        if (SelectedEnemy == null) return;

        SelectedPart = SelectedEnemy.GivePart(name);
    }

}
