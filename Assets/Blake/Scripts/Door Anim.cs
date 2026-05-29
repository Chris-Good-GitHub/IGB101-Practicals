using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    public Animation doorAnimation;
    public Transform player;
    public float interactDistance = 3f;

    void Start()
    {
        doorAnimation = GetComponent<Animation>();

        // Automatically find player if not assigned
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        // Check distance between player and door
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= interactDistance && Input.GetKeyDown(KeyCode.F))
        {
            doorAnimation.Play();
        }
    }
}