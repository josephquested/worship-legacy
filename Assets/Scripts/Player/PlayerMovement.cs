using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D rb;

	public int direction;
	public float speed;
	public bool moving;

	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}

	public void RecieveMovementInput (float horizontal, float vertical) {
		SetDirection(horizontal, vertical);
		ProcessMovement(horizontal, vertical);
	}

	void ProcessMovement (float horizontal, float vertical) {
		if (horizontal == 0 && vertical == 0) {
			moving = false;
			StopMove();
		} else {
			moving = true;
			SetDirection(horizontal, vertical);
			Move();
		}
	}

	void Move () {
		Vector2 movement = GetMovementVector();
		rb.velocity = movement * speed;
	}

	void StopMove () {
		rb.velocity = Vector2.zero;
	}

	void SetDirection (float horizontal, float vertical) {
		if (vertical == 1) direction = 0;
		if (horizontal == 1) direction = 1;
		if (vertical == -1) direction = 2;
		if (horizontal == -1) direction = 3;
	}

	Vector2 GetMovementVector () {
		Vector2 movementVector = new Vector2(0, 0);
		if (direction == 0) movementVector = new Vector2(0, 1);
		if (direction == 1) movementVector = new Vector2(1, 0);
		if (direction == 2) movementVector = new Vector2(0, -1);
		if (direction == 3) movementVector = new Vector2(-1, 0);
		return movementVector;
	}

	public int Direction {
		get { return direction; }
	}

	public bool Moving {
		get { return moving; }
	}
}
