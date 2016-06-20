using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	private GameObject screen;
  private float lerpTime;

	public float speed = 1.0F;

	public void SetScreen (GameObject newScreen)
	{
		if (screen == newScreen) return;
		screen = newScreen;
		lerpTime = Time.time;
	}

	void Update()
	{
    float distanceLerped = (Time.time - lerpTime) * speed;
		Vector3 target = new Vector3(screen.transform.position.x, screen.transform.position.y, -10f);
		float journeyLength = Vector3.Distance(transform.position, target);
		float fracJourney = distanceLerped / journeyLength;
    transform.position = Vector3.Lerp(transform.position, target, fracJourney);
  }
}
