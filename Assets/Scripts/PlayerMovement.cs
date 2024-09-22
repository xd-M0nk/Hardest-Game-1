using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        //var - sets the type of the variable to the type of the value
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");


        //normalized - equalizes the speed of the player in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            print("You died");
            
        }
    }
}
