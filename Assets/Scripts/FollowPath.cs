using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    // c# - public List<Vector3> path = new(); - initialize by hand
    //public variables in Unity are initialized in the inspector
    public List<Vector3> path;
    public float speed = 5;

    private Vector3 target;
    private int currentPoint = 0;

    private void Start() 
    {
        //move the object to the first point in the path
        target = path[0];
    }
    
    void Update()
    {
        //if the object is at the target point (within 0.3 m),
        //move to the next point
        if(Vector3.Distance(transform.position, target) < 0.3f)
        {
            //currentPoint++
            target = path[++currentPoint];
        }

        transform.LookAt(target);

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnDrawGizmos()
    {
        //Gizmos - visual debugging tool
        //DrawLine - draws a line between two points
        //Color - sets the color of the line
        Gizmos.color = Color.yellow;
        for (int i = 0; i < path.Count - 1; i++)
        {
            Gizmos.DrawLine(path[i], path[i + 1]);
        }
    }
}
