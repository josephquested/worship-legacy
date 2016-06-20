using UnityEngine;
using System.Collections;

public class ActorAnimator : MonoBehaviour
{
	private Animator animator;
	private ActorMovement actorMovement;

	void Start ()
	{
		animator = this.GetComponent<Animator>();
		actorMovement = this.GetComponent<ActorMovement>();
	}

	void FixedUpdate ()
	{
		animator.SetInteger("direction", actorMovement.Direction);
		if (actorMovement.Moving)
		{
			animator.speed = 1;
		}
		else
		{
			animator.speed = 0;
		}
	}
}
