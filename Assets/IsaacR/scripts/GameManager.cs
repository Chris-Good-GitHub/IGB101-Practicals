using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager :MonoBehaviour{
    public GameObject Player;
    //Step 2
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public Text pickupText;

    public AudioSource[] audiosources;
    public float aduioProximity = 5.0f;

    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();

    }


    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true;
        } else
        {
            levelComplete = false;
        }
    }


    private void UpdateGUI(){
        pickupText.text = "Pickup: " + currentPickups + "/" + maxPickups;
        }
}