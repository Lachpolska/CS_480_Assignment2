using UnityEngine;

public class PlayBeginningParticle : MonoBehaviour
{
    public GameObject player;

    ParticleSystem collisionParticleSystem;
    Collider particleTrigger;

    // Called when script loaded to grab the box collider and particle system
    void Awake()
    {
        collisionParticleSystem = GetComponent<ParticleSystem>();
        particleTrigger = GetComponent<Collider>();
    }

    // Enable particle system when collision with player object
    void OnTriggerEnter(Collider other)
    {
        var em = collisionParticleSystem.emission;
        if (other.gameObject == player)
        {
            em.enabled = true;
        }
    }

    // Disable particle system when player object leaves collision zone
    void OnTriggerExit(Collider other)
    {
        var em = collisionParticleSystem.emission;
        if (other.gameObject == player)
        {
            em.enabled = false;
        }
    }
}
