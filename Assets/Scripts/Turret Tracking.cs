using UnityEngine;

public class TurretTracking : MonoBehaviour
{
    public Transform target;
    public float RotationSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (target.position - transform.position).normalized;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);
    }
}
