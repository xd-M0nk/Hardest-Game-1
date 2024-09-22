using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //Unity automatically initialize public fields
    //public List<Vector3> path = new();
    //public List<Vector3> path = new List<Vector3>();
    public List<Vector3> path;
    public float speed = 2.0f;

    //private fields are not initialized by Unity
    //private List<Vector3> path = new();
    private Vector3 target;
    private int index = 0;


    void Start()
    {
        target = path[index];
    }


    void Update()
    {
        //allow 0.3 m. margin of error
        if(Vector3.Distance(transform.position, target) < 0.3f)
        {
            index++;
            if(index >= path.Count)
            {
                index = 0;
            }
            target = path[index];
        }

        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnDrawGizmos() 
    {
        //gizmos are only visible in the editor
        //Gizmos class is used to draw lines, spheres, cubes, and other simple shapes
        //Gimos.color is used to set the color of the gizmos
        //Gizmos.DrawLine is used to draw a line between two points

        Gizmos.color = Color.red;
        for (int i = 0; i < path.Count - 1; i++)
        {
            Gizmos.DrawLine(path[i], path[i + 1]);
        }
    }
}
