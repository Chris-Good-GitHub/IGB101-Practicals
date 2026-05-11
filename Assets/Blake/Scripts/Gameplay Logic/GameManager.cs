using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject player;

    // Pickup and completion logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    // UI Elements
    public Text pickupText;

    // Audio Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5f;


    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }

    public void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups -1 )
            levelComplete = true;
        else levelComplete = false;
    }

    private void UpdateGUI()
    {
        pickupText.text = $"Pickups: {currentPickups}/{maxPickups}";
    }
    private void PlayAudioSamples()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }
}
