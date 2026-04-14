using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public GameObject player;

    AudioSource source;
    Collider soundTrigger;

    // Called when script loaded to grab the box collider and music file
    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }

    // Play the audio file when collision with player object
    void OnTriggerEnter(Collider other) {
        if (other.gameObject == player)
        {
            source.Play();
        }
    }

    // Stop playing the audio file when player object leaves collision zone
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            source.Stop();
        }
    }
}
