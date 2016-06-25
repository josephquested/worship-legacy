using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrubStatus : EnemyStatus
{
	private ShrubMovement shrubMovement;

	public override void Activate ()
	{
		shrubMovement = this.GetComponent<ShrubMovement>();
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.tag == "Player" || collider.tag == "Weapon")
		{
			shrubMovement.CanMove = true;
		}
	}
}
