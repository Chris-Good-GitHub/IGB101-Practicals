using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animation doorAnimation;
    public AnimationClip openClip;
    public AnimationClip closeClip;
    
    bool doorOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorAnimation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && !doorOpen)
        {
                doorAnimation.AddClip(openClip,"Open Door");
                doorAnimation.Play();
            } else
            {
                doorAnimation.AddClip(closeClip,"Close Door");
                doorAnimation.Play();
            }
    }
}
