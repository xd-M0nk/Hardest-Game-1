using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public string sceneToLoad = "Level 1";

    void Update()
    {
        if(Input.anyKey)
        {
            //Load the scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
