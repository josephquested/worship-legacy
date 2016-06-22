using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private Collider2D attackCollider;

	[SerializeField] private Sprite[] sprites;
	[SerializeField] private int direction;
	[SerializeField] private int damage;

	void Start ()
	{
		attackCollider = this.GetComponent<Collider2D>();
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
		attackCollider.enabled = true;
		GetComponent<Renderer>().enabled = true;
	}

	public void StopAttack ()
	{
		attackCollider.enabled = false;
		GetComponent<Renderer>().enabled = false;
	}

	public int Direction
	{
		get { return direction; }
		set { direction = value; }
	}
}
