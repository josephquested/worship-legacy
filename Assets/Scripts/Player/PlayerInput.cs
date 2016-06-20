using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
	private PlayerMovement playerMovement;

	void Start ()
	{
		playerMovement = gameObject.GetComponent<PlayerMovement>();
	}

	void FixedUpdate ()
	{
		GetMovementInput();
	}

	void GetMovementInput ()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		playerMovement.RecieveMovementInput(horizontal, vertical);
	}
}
