using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builet : MonoBehaviour
{
	private float speed = 10.0F;
	private Vector3 direction;
    public Vector3 Direction { set { direction = value; } }

	private SpriteRenderer sprite;

    private void Awake()
	{
		sprite = GetComponentInChildren<SpriteRenderer>();
	}

    private void Update()
	{
        transform.position = Vector3.MoweTowards(transform.position,)
	}

}
