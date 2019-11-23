﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableMonster : Monster
{
    [SerializeField]
    private float speed = 2.0F;

    private Vector3 directed;

    private Bullet bullet;

    private SpriteRenderer sprite;

    protected override void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        bullet = Resources.Load<Bullet>("Bullet");
    }
    protected override void Start()
    {
        directed = transform.right;
    }

    protected override void Update()
    {
        Move();
    }
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();

        if(unit && unit is Character)
        {
            if (Mathf.Abs(unit.transform.position.x - transform.position.x) < 0.3F) ReceiveDamage();
            else unit.ReceiveDamage();
        }
    }
    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.5F + transform.right * directed.x * 0.5F, 0.1F);

        if (colliders.Length > 0) directed *= -1.0F;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + directed, speed * Time.deltaTime);
    }
}
