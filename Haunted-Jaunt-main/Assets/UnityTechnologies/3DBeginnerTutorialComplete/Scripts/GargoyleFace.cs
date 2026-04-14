using UnityEngine;

public class GargoyleFacing : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 10f;
    public float rotationSpeed = 2f;

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
            Quaternion targetRotation = Quaternion.LookRotation(toPlayerFlat);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}