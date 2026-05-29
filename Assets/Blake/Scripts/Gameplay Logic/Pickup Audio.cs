using UnityEngine;

public class PickupAudio : MonoBehaviour
{
    

    public AudioSource audioSource;
    public AudioClip pickupClip;

    void Start()
    {
        

        // Automatically get AudioSource if attached
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(pickupClip);
        }
    }
}