using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 2;
    public float height = 3;

    void Update()
    {
        //y coresponds to the sin of the time
        var y = Mathf.Sin(Time.time * speed) * height;

        //use absolute value (modulis) to avoid negative values
        y = Mathf.Abs(y) + 0.5f;

        //x and z are the same as in scene
        var x = transform.position.x;
        var z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
