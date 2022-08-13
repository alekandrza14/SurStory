using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testit : MonoBehaviour
{
    public string sujet;
    public int id;
    public Chara_move chara;
    public int sceneid;

    void Update()
    {
        chara = GameObject.FindWithTag("Player").GetComponent<Chara_move>();
        if (PlayerPrefs.GetInt(sujet,0) == id)
        {
            chara.poza = 0;
            SceneManager.LoadScene(sceneid);
        }
        
    }
}
