using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : ActorAttack
{
	[SerializeField] private bool passiveAttack;
	[SerializeField] private Weapon passiveWeapon;

	void Update ()
	{
		if (Input.GetKeyDown("o"))
		{
			RecieveAttackInput(true);
		}
	}

	public bool PassiveAttack
	{
		get { return passiveAttack; }
		set
		{
			passiveWeapon.PassiveAttack(value);
			passiveAttack = value;
		}
	}
}
