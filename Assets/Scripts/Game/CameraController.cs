using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	private Transform screen;
  private float lerpTime;

	public float speed = 1.0F;

	public void Start ()
	{
		screen = transform;
		lerpTime = Time.time;
	}

	public void SetScreen (Transform newScreen)
	{
		if (screen == newScreen) return;
		screen = newScreen;
		lerpTime = Time.time;
	}

	void Update ()
	{
		Vector3 target = new Vector3(screen.position.x, screen.position.y, -10f);
    float distanceLerped = (Time.time - lerpTime) * speed;
		float journeyLength = Vector3.Distance(transform.position, target);
		float fracJourney = distanceLerped / journeyLength;
		if (float.IsNaN(fracJourney)) return;
    transform.position = Vector3.Lerp(transform.position, target, fracJourney);
  }
}
