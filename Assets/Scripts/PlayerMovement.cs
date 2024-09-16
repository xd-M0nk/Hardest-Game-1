using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;


    void Update()
    {
        if(Input.GetKey(KeyCode.W)) //move forward
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) //move backwards
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) //move left
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.S)) //move right
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        print(Time.deltaTime);
    }
}
