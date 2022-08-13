using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public GameObject[] obj;
    void Update()
    {
        if (PlayerPrefs.GetInt("SUJET2", 0) == 0)
        {
            
                PlayerPrefs.SetInt("SUJET3", PlayerPrefs.GetInt("SUJET3", 0) + 1);
                PlayerPrefs.SetInt("SUJET2", 2);
            
        }
        if(PlayerPrefs.GetInt("SUJET2", 0) == 1)
        {
            PlayerPrefs.SetInt("SUJET2", 0);
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(6);
        }
    }
}
