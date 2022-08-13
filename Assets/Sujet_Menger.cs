using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sujet_Menger : MonoBehaviour
{
    public int sujet;
    public int ssujet;
    public int ssujet2;
    public int ssujet3;
    public bool zujet;
    public int ids;
    public bool save;
    void Update()
    {

        ssujet = PlayerPrefs.GetInt("SUJET", 0); 
        ssujet2 = PlayerPrefs.GetInt("SUJET2", 0);
        ssujet3 = PlayerPrefs.GetInt("SUJET3", 0);
        if (!zujet)
        {
            PlayerPrefs.SetInt("SUJET", sujet);
        }
        PlayerPrefs.SetInt("level", ids);
        if (save)
        {
            PlayerPrefs.SetInt("level1", ids);
        }
        if (PlayerPrefs.GetInt("dead", 0) == 1)
        {
            SceneManager.LoadScene("gameower");
        }
    }
}
