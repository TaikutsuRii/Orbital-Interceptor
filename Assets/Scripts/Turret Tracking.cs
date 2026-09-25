using UnityEngine;

public class TurretTracking : MonoBehaviour
{
	public float RotationSpeed = 2f;

	private Transform target;

	void Update()
	{
		if (target == null)
		{
			GameObject Drone = GameObject.FindWithTag("Drone");

			if (Drone != null)
				target = Drone.transform;
			else
				return;
		}

		Vector3 direction = (target.position - transform.position).normalized;

		Quaternion targetRotation = Quaternion.LookRotation(direction);

		transform.rotation = Quaternion.Slerp(
		transform.rotation,
		targetRotation,
		RotationSpeed * Time.deltaTime
		);
	}
}
