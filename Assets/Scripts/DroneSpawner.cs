using System.Collections;
using UnityEngine;

public class DroneSpawner : MonoBehaviour
{
	public static DroneSpawner Instance;

	public GameObject dronePrefab;

	private void Awake()
	{
		Instance = this;
	}

	public void SpawnAfterDelay()
	{
		StartCoroutine(SpawnRoutine());
	}

	IEnumerator SpawnRoutine()
	{
		yield return new WaitForSeconds(Random.Range(1f, 2f));

		Instantiate(dronePrefab, transform.position, Quaternion.identity);
	}
}
