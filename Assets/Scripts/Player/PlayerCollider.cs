using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	private CameraController cameraController;

	void Start () {
		cameraController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
	}

	void OnTriggerStay2D (Collider2D collider) {
		if (collider.tag == "Screen") {
			cameraController.MoveTo(new Vector3(
				collider.transform.position.x,
				collider.transform.position.y +0.5f,
				-10f
			));
		}
	}
}
