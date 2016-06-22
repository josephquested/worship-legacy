using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private Collider2D collider2D;

	[SerializeField] private Sprite[] sprites;
	[SerializeField] private int direction;
	[SerializeField] private int damage;

	void Start ()
	{
		collider2D = this.GetComponent<Collider2D>();
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.tag == "Enemy")
		{
			print(collider.gameObject.name);
			// collider send message
		}
	}

	public void AttackInDirection (int direction)
	{
		collider2D.enabled = true;
	}

	public void StopAttack ()
	{
		collider2D.enabled = false;
	}

	public int Direction
	{
		get { return direction; }
		set { direction = value; }
	}
}
