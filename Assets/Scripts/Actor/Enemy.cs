using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private Vector2 spawnLocation;
	private ActorMovement actorMovement;

	void Start ()
	{
		spawnLocation = transform.position;
		actorMovement = this.GetComponent<ActorMovement>();
	}

	void Reset ()
	{
		actorMovement.CanMove = false;
		transform.position = spawnLocation;
	}

	void Activate ()
	{
		actorMovement.CanMove = true;
	}
}
