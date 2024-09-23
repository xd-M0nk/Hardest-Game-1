using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructable : MonoBehaviour
{
    void Start()
    {
        //DontDestroyOnLoad - makes the object indestructable, same music player in all scenes
        DontDestroyOnLoad(gameObject);
    }

}
