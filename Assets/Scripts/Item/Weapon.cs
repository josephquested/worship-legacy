using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private Collider2D attackCollider;
	private SpriteRenderer spriteRenderer;

	[SerializeField] private Sprite[] sprites;
	[SerializeField] private int direction;
	[SerializeField] private int damage;

	void Start ()
	{
		attackCollider = this.GetComponent<Collider2D>();
		spriteRenderer = this.GetComponent<SpriteRenderer>();
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
		spriteRenderer.enabled = true;
	}

	public void StopAttack ()
	{
		attackCollider.enabled = false;
		spriteRenderer.enabled = false;
	}

	public int Direction
	{
		get { return direction; }
		set { direction = value; }
	}
}
