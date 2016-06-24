using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private Collider2D attackCollider;
	private SpriteRenderer spriteRenderer;

	[SerializeField] private Sprite[] sprites;
	[SerializeField] private int damage;
	[SerializeField] private int knockback;

	void Start ()
	{
		attackCollider = this.GetComponent<Collider2D>();
		spriteRenderer = this.GetComponent<SpriteRenderer>();
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		Transform player = GameObject.FindGameObjectWithTag("Player").transform;
		if (collider.tag == "Enemy")
		{
			Vector2 fromVector2 = collider.transform.position;
			Vector2 toVector2 = GameObject.FindGameObjectWithTag("Player").transform.position;
			Vector2 dir = (fromVector2 - toVector2).normalized;
			dir = dir.normalized;
			float x = Mathf.Round(dir.x);
			float y = Mathf.Round(dir.y);
			Vector2 direction = new Vector2(x, y);
			collider.gameObject.GetComponent<Rigidbody2D>().velocity = direction * knockback;
			// works with transform.translate, but when trying to use rigid body, it is broken
			// because every time they move, their transform is being zeroed.
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
