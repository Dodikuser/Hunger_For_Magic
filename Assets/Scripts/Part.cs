using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : Entity, ITakeDamage
{
    public Element Element { get; private set; }

    public void TakeDamage(float damage)
    {
        Hp -= damage;
    }
}
