using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAttack : MonoBehaviour
{
	[SerializeField] private bool attacking;
	[SerializeField] private float attackSpeed;

	public void RecieveAttackInput (bool attackInput)
	{
		ProcessAttack(attackInput);
	}

	void ProcessAttack (bool attackInput)
	{
		if (!attacking && attackInput)
		{
			StartCoroutine(AttackCoroutine());
		}
	}


	IEnumerator AttackCoroutine ()
	{
		float duration = attackSpeed;
		attacking = true;

		while (duration >= 0)
		{
			duration -= 0.1f;
			Attack();
			yield return new WaitForSeconds(0.01f);
		}

		attacking = false;
	}

	void Attack ()
	{

	}

	public bool Attacking
	{
		get { return attacking; }
	}
}
