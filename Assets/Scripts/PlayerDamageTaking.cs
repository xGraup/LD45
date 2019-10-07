﻿using UnityEngine;
using System.Collections;

public class PlayerDamageTaking : DamageTaking
{
    private int lifeUnits = 0;

    public override void TakeDamage(int damage)
    {
        if(lifeUnits <= 0)
        {
            base.TakeDamage(damage);
        }
    }
}
