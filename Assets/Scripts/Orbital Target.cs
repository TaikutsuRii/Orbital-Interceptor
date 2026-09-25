using UnityEngine;

public class OrbitalTarget : MonoBehaviour
{
	public Transform pointA, pointB;
	public float travelDuration;

	private float timer;
	private bool toB = true;

	void Start()
	{
		pointA = GameObject.Find("Point A").transform;
		pointB = GameObject.Find("Point B").transform;
	}

	void Update()
	{
		timer += Time.deltaTime;
		float t = timer / travelDuration;

		Vector3 start = toB ? pointA.position : pointB.position;
		Vector3 target = toB ? pointB.position : pointA.position;

		transform.position = Vector3.Lerp(start, target, t);

		if (t > 1f)
		{
			timer = 0;
			toB = !toB;
		}
	}
}
