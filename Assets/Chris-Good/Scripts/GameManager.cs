using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text pickupText;

    //pick-up and level completion logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;
    public DoorAnimation doorAnimation;
    public PortalRiseAnimation portalAnimation;
    public GameObject portalEffects;

    //Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        portalEffects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        if (Input.GetKeyDown("f"))
        {
            doorAnimation.OpenDoor();
        }
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
            portalAnimation.RaisePortal();
            portalEffects.SetActive(true);
        } else
        {
            levelComplete = false;
        }
    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
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
