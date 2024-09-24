using UnityEngine;
using UnityEngine.SceneManagement;

public class InputDetector : MonoBehaviour
{
    public string nextScene;

    void Update()
    {
        if(Input.anyKey) SceneManager.LoadScene(nextScene);
    }
}
