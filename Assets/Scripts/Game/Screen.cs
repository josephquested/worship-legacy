using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
	private ScreenController screenController;

	void Start ()
	{
		screenController = transform.parent.GetComponent<ScreenController>();
	}

	void OnTriggerStay2D (Collider2D collider)
	{
		if (collider.tag == "Player") {
			screenController.ActiveScreen = this;
			BroadcastMessage("Activate", SendMessageOptions.DontRequireReceiver);
		}
	}

	void OnTriggerExit2D (Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			screenController.ActiveScreen = this;
			BroadcastMessage("Reset", SendMessageOptions.DontRequireReceiver);
		}
	}
}
