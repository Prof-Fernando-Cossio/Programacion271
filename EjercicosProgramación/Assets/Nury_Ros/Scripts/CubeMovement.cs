using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform point_a,point_b;
    public int speed=2;
    Transform where_to_go;

    void Start()
    {
        where_to_go=point_a;
    }
    
    void Update()
    {
        transform.position=Vector3.MoveTowards(transform.position , where_to_go.position,speed*Time.deltaTime);
        
        //Vector3.MoveTowards(posicion actual,posicion de destino,cuanto avanzo)
        
        if (Vector3.Distance(transform.position,where_to_go.position) < .1f) 
        //Vector3.Distance(obtener distancia entre 2 posiciones)
        {
            if (where_to_go==point_b)
            {
            where_to_go=point_a;
            }
            else 
            {
                where_to_go=point_b;
            }

        }
    }
}
