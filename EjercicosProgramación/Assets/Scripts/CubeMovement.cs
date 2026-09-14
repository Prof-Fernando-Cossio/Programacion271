using System;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed;
    public float distance;
    int dir = 1;

    

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(transform.position.x) > distance)
        {
            dir *= -1;
        }
        Vector3 moveDirection = new Vector3(speed * dir, 0, 0);

        transform.position += moveDirection;

    }
}
