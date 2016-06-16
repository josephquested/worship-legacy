using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	private PlayerMovement playerMovement;

	void Start () {
		playerMovement = gameObject.GetComponent<PlayerMovement>();
	}

	void Update () {
		MovementInput();
	}

	void MovementInput () {
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		playerMovement.RecieveMovementInput(horizontal, vertical);
	}
}
