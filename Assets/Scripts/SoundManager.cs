using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;
    public AudioSource thunderRumble;
    public AudioSource backgroundNoise;
    public bool playing = false;

    private void Awake()
    {
        if (soundManager == null)
        {
            soundManager = this;
        }
        AudioSource background = Instantiate(backgroundNoise, Vector3.zero, Quaternion.identity);
        background.clip = backgroundNoise.clip;
        background.volume = 0.1f;
        background.Play();
        background.loop = true;
    }


    public void Play(AudioClip rumble, Transform position, float volume)
    {
        AudioSource audioSource = Instantiate(thunderRumble, position.position, Quaternion.identity);
        audioSource.clip = rumble;
        audioSource.volume = volume;
        audioSource.Play();
        float playLength = audioSource.clip.length;
        Destroy(audioSource.gameObject, playLength);
    }
}
