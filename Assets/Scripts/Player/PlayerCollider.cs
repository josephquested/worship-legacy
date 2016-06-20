using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour
{
	private CameraController cameraController;

	void Start ()
	{
		cameraController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
	}

	void OnTriggerStay2D (Collider2D collider)
	{
		if (collider.tag == "Screen") {
			cameraController.SetScreen(collider.gameObject);
		}
	}
}
