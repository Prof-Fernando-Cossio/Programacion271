using UnityEngine;

public class Move_Cube : MonoBehaviour
{
    public GameObject[] waypoints;

    public float speed = 2;

    private int waypointsIndex = 0;

   
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
