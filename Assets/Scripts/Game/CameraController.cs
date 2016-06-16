using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public void MoveTo (Vector3 screenPosition) {
		transform.position = screenPosition;
	}
}
