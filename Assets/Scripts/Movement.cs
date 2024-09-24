using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;

    private Vector3 startPosition;

    private void Start() 
    {
        startPosition = transform.position;
    }

    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        //look at the direction of the movement
        if(x != 0 || z != 0)
            transform.forward = new Vector3(x, 0, z);

        //new Vector3(x, 0, z).normalized move equally in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy")){
            print("Game Over");
            transform.position = startPosition;
        }
    }
}
