using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPLWeapon
{
    public enum TypeDamage
    {
        �utting,
        Stabbing,
        �rushing
    }

    public void ElementCange(string name);
    public void Fire(Enemy enemy);
}
public interface IElement
{
    public string Name { get; set; }
    public Dictionary<IElement, int> ElementFactors { get; set; }
}
