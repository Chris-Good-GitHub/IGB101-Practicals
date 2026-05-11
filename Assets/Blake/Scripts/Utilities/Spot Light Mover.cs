using UnityEngine;

public class SpotLightMover : MonoBehaviour
{
    public float min = -5f;
    public float max = 5f;
    public float speed = 2f;

    public bool useZAxis = false; // Toggle between X and Z movement

    private bool movingForward = true;

    void Update()
    {
        Vector3 pos = transform.position;

        if (movingForward)
        {
            if (useZAxis)
                pos.z += speed * Time.deltaTime;
            else
                pos.x += speed * Time.deltaTime;

            if ((useZAxis && pos.z >= max) || (!useZAxis && pos.x >= max))
            {
                if (useZAxis)
                    pos.z = max;
                else
                    pos.x = max;

                movingForward = false;
            }
        }
        else
        {
            if (useZAxis)
                pos.z -= speed * Time.deltaTime;
            else
                pos.x -= speed * Time.deltaTime;

            if ((useZAxis && pos.z <= min) || (!useZAxis && pos.x <= min))
            {
                if (useZAxis)
                    pos.z = min;
                else
                    pos.x = min;

                movingForward = true;
            }
        }

        transform.position = pos;
    }
}