using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //public variables in unity are initialized in the editor
    //public List<Vector3> path = new List<Vector3>();
    //public List<Vector3> path = new();
    public List<Vector3> path;
    public float speed = 3;

    private Vector3 target;
    private int currentPoint = 0;

    void Start()
    {
        target = path[currentPoint];
    }

    void Update()
    {
        //allow 0.3 m of error
        if(Vector3.Distance(transform.position, target) < 0.3f)
        {
            //currentPoint++;
            target = path[++currentPoint];
        }

        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;

    }

    public void OnDrawGizmos()
    {
        //draw the path
        //Gizmos - a class that allows you to draw shapes in the scene view
        //Gizmos.color - set the color of the shapes
        //Gizmos.DrawLine - draw a line between two points

        Gizmos.color = Color.green;
        for (int i = 0; i < path.Count - 1; i++)
        {
            Gizmos.DrawLine(path[i], path[i + 1]);
        }
    }
}
