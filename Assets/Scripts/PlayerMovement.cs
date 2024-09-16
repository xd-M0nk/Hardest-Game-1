using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        //var - select the type of variable
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        //normalized - move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }
}
