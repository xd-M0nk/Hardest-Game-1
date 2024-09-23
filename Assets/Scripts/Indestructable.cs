using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructable : MonoBehaviour
{
    void Start()
    {
        //DontDestroyOnLoad - makes the object indestructable when loading a new scene, every level will have the object
        DontDestroyOnLoad(gameObject);
    }

   
}
