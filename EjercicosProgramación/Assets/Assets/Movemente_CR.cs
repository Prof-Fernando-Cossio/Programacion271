using UnityEngine;

public class Movemente_CR : MonoBehaviour
{

    public GameObject[] waypoints;

    public float CubeSpeed = 2;

    private int waypointsIndex = 0;

    void Update()
    {

        CubeMove();

    }

    void CubeMove()
    {

        if (Vector3.Distance(transform.position, waypoints[waypointsIndex].transform.position) < 0.1f)
        {

            waypointsIndex++;

            if (waypointsIndex >= waypoints.Length)
            {
                waypointsIndex = 0;
            }

        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position, CubeSpeed*Time.deltaTime);

    }

}
