using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class testit3 : MonoBehaviour
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
            if (PlayerPrefs.GetInt("fighting", 0) == 0)
            {
                Directory.CreateDirectory("save");
                File.WriteAllText(@"save/save1", "2");
                chara.poza = 1;
                PlayerPrefs.SetInt(sujet, 0);
                SceneManager.LoadScene(sceneid);
            }
        }
        
    }
}
