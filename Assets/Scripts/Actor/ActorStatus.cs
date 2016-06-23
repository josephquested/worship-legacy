using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorStatus : MonoBehaviour
{
	[SerializeField] private int health;

	public int Health {
		get { return health; }
		set { health = value; }
	}
}
