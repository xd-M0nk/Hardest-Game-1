using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //no need to get whole game object, just the transform component 
    //(transform.position, transform.rotation, transform.localScale)
    public Transform target;
    public float speed = 5;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.LookAt(target);
        //transform.forward vs Vector3.forward
        //transform.forward is relative to the object's rotation
        //Vector3.forward is always the same direction
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.position = startPos;
        }
    }
}
