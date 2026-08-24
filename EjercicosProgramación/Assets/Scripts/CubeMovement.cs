using UnityEngine;
using System;

public class CubeMovement : MonoBehaviour
{
    public float speed;
    public float distance;
    int dir = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(transform.position.x) > distance)
        {
            dir*=-1;
        }
        Vector3 moveDirection = new Vector3(speed * dir, 0, 0);

        transform.position += moveDirection;

    }
}
