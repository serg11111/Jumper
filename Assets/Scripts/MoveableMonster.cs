using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableMonster : Monster
{
    [SerializeField]
    private float speed = 2.0F;

    private Bullet bullet;

    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();

        if(unit && unit is Character)
        {
            ReceiveDamage();
        }
    }
}
