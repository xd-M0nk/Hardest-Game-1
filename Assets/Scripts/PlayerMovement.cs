using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    public Vector3 startPos;

    private AudioSource audioSource;

    void Start()
    {
        startPos = transform.position;
        //get the audio source component that is attached to the player
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //var - sets the type of the variable to the type of the value
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        //rotate towards the direction of movement
        if(x != 0 || z != 0)
        {
            transform.forward = new Vector3(x, 0, z);
        }

        //normalized - equalizes the speed of the player in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            audioSource.Play();

            //delay scene loading by 2s to play sound first
            Invoke("ReloadScene", 2);
        }
    }

    void ReloadScene()
    {
            //on death reload level
            var sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);
    }
}
