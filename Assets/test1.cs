using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test1 : MonoBehaviour
{
    public GameObject[] obj;
    public int id;
    public void Start()
    {
        if (PlayerPrefs.GetInt("SUJET4", 0) == 1)
        {
            PlayerPrefs.SetInt("SUJET4", 0);
        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("SUJET2", 0) == 0)
        {
            
                PlayerPrefs.SetInt("SUJET3", PlayerPrefs.GetInt("SUJET3", 0) + 1);
                PlayerPrefs.SetInt("SUJET2", 2);
            
        }
        if(PlayerPrefs.GetInt("SUJET2", 0) == 1)
        {
            PlayerPrefs.SetInt("SUJET4", 1);
            PlayerPrefs.SetInt("SUJET2", 0);
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(id);
        }
    }
}
