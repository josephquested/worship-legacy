using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : ActorStatus
{
	private EnemyAttack enemyAttack;
	private Vector2 spawnLocation;
	private int spawnDirection;

	void Start ()
	{
		enemyAttack = this.GetComponent<EnemyAttack>();
		spawnLocation = transform.position;
		spawnDirection = actorMovement.Direction;
	}

	void Reset ()
	{
		actorMovement.CanMove = false;
		actorMovement.Direction = spawnDirection;
		transform.position = spawnLocation;
		enemyAttack.PassiveAttack = true;
		Respawn();
	}

	public override void Die ()
	{
		spriteRenderer.enabled = false;
		actorCollider.enabled = false;
		enemyAttack.PassiveAttack = false;
	}

	public virtual void Activate ()
	{
		actorMovement.CanMove = true;
	}

	void Respawn ()
	{
		Health = BaseHealth;
		spriteRenderer.enabled = true;
		actorCollider.enabled = true;
	}
}
