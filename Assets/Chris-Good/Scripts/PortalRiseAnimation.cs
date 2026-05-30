using UnityEngine;

public class PortalRiseAnimation : MonoBehaviour
{
    [SerializeField] private Animator portal;
    [SerializeField] private bool state = false;

    public void RaisePortal()
    {
        portal.Play("Portal Rise");
    }
}
