using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : ActorAttack
{
	[SerializeField] private bool passiveAttack;

	public bool PassiveAttack
	{
		get { return passiveAttack; }
		set
		{
			weapon.PassiveAttack(value);
			passiveAttack = value;
		}
	}
}
