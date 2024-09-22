using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float speed = 3;

    void Update()
    {
        transform.LookAt(target);

        // Vector3.forward vs transform.forward
        //transfor.forward local direction like right, left
        //Vector3.forward global direction like north, south

        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
