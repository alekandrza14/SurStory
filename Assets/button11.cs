using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class button11 : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D s)
    {
        
        if (s.gameObject.tag == "i")
        {
            PlayerPrefs.SetInt("iy2", 1);
        }
    }
}
