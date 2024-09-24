using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    Vector3 startPos;

    private void Start() 
    {
        startPos = transform.position;
    }


    void Update()
    {
        //var - select the type of variable
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        //look at the direction of the movement
        if(x != 0 || z != 0) //rotate only if there is movement
            transform.forward = new Vector3(x, 0, z);

        //normalized - move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            print("Game Over");
            transform.position = startPos;
        }
    }
}
