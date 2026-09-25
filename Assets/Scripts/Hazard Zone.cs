using UnityEngine;

public class HazardZone : MonoBehaviour
{
    public int penaltyPoints = 5;

    private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Drone"))
		{
			// Deduct points from the player's score when they enter the hazard zone
			GameManager.Instance.RemoveScore(penaltyPoints);
		}
	}
}
