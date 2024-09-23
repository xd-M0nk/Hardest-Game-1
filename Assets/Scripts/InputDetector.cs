
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public string sceneName = "Level 1";

    void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
