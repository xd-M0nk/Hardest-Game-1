using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //unity initialize the PUBLIC list for us
    public List<Vector3> path;

    //unity doesnt initialize the PRIVATE list for us
    //private List<Vector3> path = new();


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //ondrawgizmos is a unity function that is called when the object is selected
    private void OnDrawGizmos() 
    {
        //Gizmos class is a unity class that allows us to draw shapes in the scene view
        //Gizmos.color sets the color of the shape
        //Gizmos.DrawLine draws a line between two points

        Gizmos.color = Color.red;
        for (int i = 0; i < path.Count - 1; i++)
        {
            Gizmos.DrawLine(path[i], path[i + 1]);
        }
    }
}
