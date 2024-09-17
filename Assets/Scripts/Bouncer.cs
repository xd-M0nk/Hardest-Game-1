using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float speed = 5.0f;
    public float height = 3f;

    void Update()
    {
        var y = Mathf.Sin(Time.time * speed) * height;

        //make y always positive - use absolute value
        y = Mathf.Abs(y); //+1, -1 (adjust)

        var x = transform.position.x;
        var z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
