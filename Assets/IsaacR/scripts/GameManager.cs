using UnityEngine;

public class GameManager :MonoBehaviour{
    public GameObject player;
    //Step 2
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;


private void levelCompleteCheck()
{
    if (currentPickups >= maxPickups)
        levelComplete = true;
    else
        levelComplete = false;
}

void Update()
    {
        levelCompleteCheck();
    }
}