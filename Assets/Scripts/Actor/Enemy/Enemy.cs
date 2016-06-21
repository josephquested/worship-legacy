using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private Vector2 spawnLocation;
	private int spawnDirection;
	private ActorMovement actorMovement;

	void Start ()
	{
		actorMovement = this.GetComponent<ActorMovement>();
		spawnLocation = transform.position;
		spawnDirection = actorMovement.Direction;
	}

	void Reset ()
	{
		actorMovement.CanMove = false;
		actorMovement.Direction = spawnDirection;
		transform.position = spawnLocation;
	}

	void Activate ()
	{
		actorMovement.CanMove = true;
	}
}
