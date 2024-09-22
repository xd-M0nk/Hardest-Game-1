using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float speed = 2.0f;

    void Update()
    {
        transform.LookAt(target);

        //transform.forward vs Vector3.forward
        //transform.forward is the forward direction of the object, left, right, up, down, forward, and backward
        //Vector3.forward is the forward direction of the world, south, east, north, and west
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
