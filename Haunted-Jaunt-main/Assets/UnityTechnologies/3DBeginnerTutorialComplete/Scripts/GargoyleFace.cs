using UnityEngine;

public class GargoyleFacing : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 10f;
    public float rotationSpeed = 1f;

    void Update()
    {
        Vector3 toPlayer = player.position - transform.position;
        float distance = toPlayer.magnitude;

        if (distance < detectionRadius)
        {
            // Flatten to horizontal plane
            Vector3 toPlayerFlat = new Vector3(toPlayer.x, 0f, toPlayer.z).normalized;

            // Use dot product to determine how much the gargoyle is already facing the player
            float dot = Vector3.Dot(transform.forward, toPlayerFlat);

            // Only rotate if it is not already well-aligned
            if (dot < 0.99f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(toPlayerFlat);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
    }
}