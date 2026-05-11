using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwitch : MonoBehaviour
{
    GameManager gameManager;
    public string nextLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player"){
            if (gameManager.levelComplete)
            {
                Debug.Log("LOAD SCENE");
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
