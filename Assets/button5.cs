using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class button5 : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D s)
    {
        
        if (s.gameObject.tag == "i")
        {
            PlayerPrefs.SetInt("iy", 1);
        }
    }
}
