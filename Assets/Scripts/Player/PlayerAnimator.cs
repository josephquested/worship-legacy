using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {

	private Animator animator;
	private PlayerMovement playerMovement;

	void Start () {
		animator = this.GetComponent<Animator>();
		playerMovement = this.GetComponent<PlayerMovement>();
	}

	void FixedUpdate () {
		animator.SetInteger("direction", playerMovement.Direction);
		if (playerMovement.Moving) {
			animator.speed = 1;
		} else {
			animator.speed = 0;
		}
	}
}
