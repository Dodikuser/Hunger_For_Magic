using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPLWeapon
{
    public enum TypeDamage
    {
        Ñutting,
        Stabbing,
        Ñrushing
    }

    public void ElementCange(string name);
    public void Fire(Enemy enemy);
}

