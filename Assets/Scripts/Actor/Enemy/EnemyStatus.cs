using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : ActorStatus
{
	private Vector2 spawnLocation;
	private int spawnDirection;

	void Start ()
	{
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
		actorCollider.enabled = true;
	}
}
