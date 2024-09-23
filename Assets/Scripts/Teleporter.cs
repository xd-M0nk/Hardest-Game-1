using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
   public string sceneToLoad;

   private void OnCollisionEnter(Collision other) 
   {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
         
   }
}
