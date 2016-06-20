﻿using UnityEngine;
using System.Collections;

public class ActorMovement : MonoBehaviour
{
	private Rigidbody2D rb;

	public int direction;
	public float speed;
	public bool moving;

	void Start ()
	{
		rb = this.GetComponent<Rigidbody2D>();
	}

	public void RecieveMovementInput (float horizontal, float vertical)
	{
		int newDirection = GetDirectionInt(horizontal, vertical);
		ProcessMovement(newDirection);
	}

	public void ProcessMovement (int newDirection)
	{
		if (newDirection == 5)
		{
			moving = false;
			StopMove();
		}
		else
		{
			moving = true;
			direction = newDirection;
			Move(direction);
		}
	}

	void Move (int direction)
	{
		Vector2 movement = GetMovementVector(direction);
		rb.velocity = movement * speed;
	}

	void StopMove ()
	{
		rb.velocity = Vector2.zero;
	}

	int GetDirectionInt (float horizontal, float vertical)
	{
		if (vertical == 1) return 0;
		if (horizontal == 1) return 1;
		if (vertical == -1) return 2;
		if (horizontal == -1) return 3;
		else return 5;
	}

	Vector2 GetMovementVector (int newDirection)
	{
		Vector2 movementVector = new Vector2(0, 0);
		if (newDirection == 0) movementVector = new Vector2(0, 1);
		if (newDirection == 1) movementVector = new Vector2(1, 0);
		if (newDirection == 2) movementVector = new Vector2(0, -1);
		if (newDirection == 3) movementVector = new Vector2(-1, 0);
		return movementVector;
	}

	public int Direction
	{
		get { return direction; }
	}

	public bool Moving
	{
		get { return moving; }
	}
}
