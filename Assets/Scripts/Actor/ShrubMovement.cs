using UnityEngine;
using System.Collections;

public class ShrubMovement : ActorMovement
{
	public bool movementCoroutine;
	public float minMovement;
	public float maxMovement;

	void Update ()
	{
		if (!movementCoroutine)
		{
			movementCoroutine = true;
			StartCoroutine(MoveAtRandom());
		}
	}

	IEnumerator MoveAtRandom ()
	{
		int newDirection = Random.Range(0, 4);
		float duration = Random.Range(minMovement, maxMovement);

		while (duration >= 0)
		{
			duration -= 0.1f;
			ProcessMovement(newDirection);
			yield return new WaitForSeconds(0.01f);
		}

		movementCoroutine = false;
	}
}
