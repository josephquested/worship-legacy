using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private Vector2 spawnLocation;
	private int spawnDirection;
	private ActorMovement actorMovement;
	private SpriteRenderer spriteRenderer;
	private Collider2D enemyCollider;

	void Start ()
	{
		actorMovement = this.GetComponent<ActorMovement>();
		spriteRenderer = this.GetComponent<SpriteRenderer>();
		enemyCollider = this.GetComponent<Collider2D>();
		spawnLocation = transform.position;
		spawnDirection = actorMovement.Direction;
	}

	void Reset ()
	{
		actorMovement.CanMove = false;
		actorMovement.Direction = spawnDirection;
		transform.position = spawnLocation;
		Respawn();
	}

	void Activate ()
	{
		actorMovement.CanMove = true;
	}

	void Respawn ()
	{
		spriteRenderer.enabled = true;
		enemyCollider.enabled = true;
	}

	public void Die ()
	{
		spriteRenderer.enabled = false;
		enemyCollider.enabled = false;
	}

	public void DieForever ()
	{
		Destroy(gameObject);
	}
}
