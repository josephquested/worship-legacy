using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private Collider2D attackCollider;
	private SpriteRenderer spriteRenderer;

	[SerializeField] private Sprite[] sprites;
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
			collider.GetComponent<Enemy>().Die();
		}
	}

	public void AttackInDirection (int direction)
	{
		SetDirection(direction);
		attackCollider.enabled = true;
		spriteRenderer.enabled = true;
	}

	public void StopAttack ()
	{
		attackCollider.enabled = false;
		spriteRenderer.enabled = false;
	}

	void SetDirection (int direction)
	{
		spriteRenderer.sprite = sprites[direction];
		if (direction == 0) transform.localPosition = new Vector2(0, 1);
		if (direction == 1) transform.localPosition = new Vector2(1, 0);
		if (direction == 2) transform.localPosition = new Vector2(0, -1);
		if (direction == 3) transform.localPosition = new Vector2(-1, 0);
	}
}
