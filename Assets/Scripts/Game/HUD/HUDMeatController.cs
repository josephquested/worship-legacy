using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDMeatController : MonoBehaviour
{
	private PlayerStatus playerStatus;

	[SerializeField] private HUDMeat[] hudMeat;

	void Start ()
	{
		playerStatus = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
		UpdateBones();
	}

	void UpdateBones ()
	{
		for (int i = 1; i < hudMeat.Length; i++)
		{
			hudMeat[i].transform.localPosition = new Vector2(
				hudMeat[i - 1].transform.localPosition.x + 1,
				0
			);
		}
	}

	void UpdateMeat ()
	{

	}
}
