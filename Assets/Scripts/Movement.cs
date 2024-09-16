using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        //new Vector3(x, 0, z).normalized move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }
}
