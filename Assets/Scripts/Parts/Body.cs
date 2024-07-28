using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : Part
{
    public override string ToString()
    {
        return "Body";
    }
    public override void Die()
    {
        base.Die();
        ParentEnemy.Die();
    }
}
