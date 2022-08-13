using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class button1 : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D s)
    {
        
        if (s.gameObject.tag == "Player")
        {
            if (PlayerPrefs.GetInt("fighting",0) == 0)
            {
                SceneManager.LoadScene("fighting");
            }
        }
    }
}
