using UnityEngine;

public class Player : Entity, ICombatable, IChanger
{
    public Enemy SelectedEnemy;
    public Part SelectedPart;
    public string SelectedPartName;
    public PlWeapon PLWeapon;
    public Inventory Inventory = new Inventory();

    private void Awake()
    {
        CurrentHealth = MaxHealth;
        
    }
    private void Start()
    {
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
       // if (SelectedEnemy != null && entity == null)
        SelectedPart = SelectedEnemy.GivePart(SelectedPartName);
        PLWeapon.DealDamage(SelectedPart);
    }

    public void SetWeapon()
    {
        throw new System.NotImplementedException();
    }

    public void SetAmulet()
    {
        throw new System.NotImplementedException();
    }   

    public void SelectPartName(string name)
    {
        SelectedPartName = name;
    }

}
