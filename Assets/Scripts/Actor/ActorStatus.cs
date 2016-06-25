﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorStatus : MonoBehaviour
{
	[SerializeField] private int health;
	[SerializeField] private bool invulnerable;

	protected Collider2D actorCollider;
	protected SpriteRenderer spriteRenderer;
	protected ActorMovement actorMovement;

	void Awake ()
	{
		actorMovement = this.GetComponent<ActorMovement>();
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		actorCollider = this.GetComponent<Collider2D>();
	}

	public int Health
	{
		get { return health; }
		set { health = value; }
	}

	public bool Invulnerable
	{
		get { return invulnerable; }
		set { invulnerable = value; }
	}

	public void Damage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	public virtual void Die ()
	{
		spriteRenderer.enabled = false;
		actorCollider.enabled = false;
	}

	public void DieForever ()
	{
		Destroy(gameObject);
	}
}
