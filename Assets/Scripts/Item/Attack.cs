using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	[SerializeField] Sprite[] sprites;
	[SerializeField] int direction;

	void OnTriggerEnter2D (Collider2D collider)
	{
		print(collider.gameObject.name);
		// collider send message
	}

	public int Direction
	{
		get { return direction; }
		set { direction = value; }
	}
}
