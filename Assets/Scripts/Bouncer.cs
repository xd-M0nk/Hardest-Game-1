using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float speed = 5.0f;
    public float height = 3.0f;

    void Update()
    { 
        //y is now a sine wave (moves up and down)
        var y =  Mathf.Sin(Time.time * speed) * height;

        if(y < 0) y = -y;
       
        //x and z reman the same
        var x = transform.position.x;
        var z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
