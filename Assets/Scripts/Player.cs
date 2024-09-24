using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        //var - chooses the type of variable automatically
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");


        //look in the direction of movement
        if(x != 0 || z != 0)
        {
            transform.forward = new Vector3(x, 0, z);
        }

        //Move the player
        //new Vector3(x, 0, z).normalized - makes the player move at the same speed 
        //in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            print("Game Over");
            //Restart the scene
            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }
    }
}
