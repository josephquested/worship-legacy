using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator = this.GetComponent<Animator>();
	}

	public void RecieveMovementInput (float horizontal, float vertical) {
		if (vertical > 0)
		{
			animator.SetInteger("direction", 0);
		}
		else if (vertical < 0)
		{
			animator.SetInteger("direction", 2);
		}
		else if (horizontal > 0)
		{
			animator.SetInteger("direction", 1);
		}
		else if (horizontal < 0)
		{
			animator.SetInteger("direction", 3);
		}
	}
}
