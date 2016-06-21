using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
	private ScreenController screenController;
	public bool screenActive = false;

	void Start ()
	{
		screenController = transform.parent.GetComponent<ScreenController>();
	}

	void Update ()
	{
		screenController.SetScreenState(this);
	}

	void OnTriggerStay2D (Collider2D collider)
	{
		if (collider.tag == "Player")
		{
			screenController.ActiveScreen = this;
		}
	}

	public void ResetScreen ()
	{
		if (!screenActive) return;
		screenActive = false;
		BroadcastMessage("Reset", SendMessageOptions.DontRequireReceiver);
	}

	public void ActivateScreen ()
	{
		if (screenActive) return;
		screenActive = true;
		BroadcastMessage("Activate", SendMessageOptions.DontRequireReceiver);
	}
}
