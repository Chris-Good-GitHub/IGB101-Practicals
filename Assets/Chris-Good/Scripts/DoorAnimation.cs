using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    [SerializeField] private Animator doorAnimation;
    [SerializeField] private bool doorOpen = true;

    public void OpenDoor()
    {
        if (doorOpen)
        {
            doorAnimation.Play("Open Door");
            doorOpen = !doorOpen;
        } else
        {
            doorAnimation.Play("Close Door");
            doorOpen = !doorOpen;
        }
    }
}
