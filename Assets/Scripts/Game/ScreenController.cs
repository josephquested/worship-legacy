using UnityEngine;
﻿using System.Collections;

public class ScreenController : MonoBehaviour
{
	private CameraController cameraController;
	private Screen activeScreen;

	void Start ()
	{
		cameraController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
	}

	public void SetScreenState (Screen screen)
	{
		if (screen == activeScreen && !cameraController.Transitioning)
		{
			screen.ActivateScreen();
		}
		else if (screen != activeScreen && !cameraController.Transitioning)
		{
			screen.ResetScreen();
		}
	}

	public Screen ActiveScreen
	{
		get { return activeScreen; }
		set
		{
			activeScreen = value;
			cameraController.SetScreen(activeScreen.gameObject.transform);
		}
	}
}
