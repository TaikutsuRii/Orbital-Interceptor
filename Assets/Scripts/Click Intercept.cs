using UnityEngine;

public class ClickIntercept : MonoBehaviour
{
	public int scoreValue = 10;

	private void OnMouseDown()
	{
		Debug.Log("CLICKED");

		GameManager.Instance.AddScore(scoreValue);

		DroneSpawner.Instance.SpawnAfterDelay();

		Destroy(gameObject);
	}
}
