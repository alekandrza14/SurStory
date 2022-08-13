using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class testit4 : MonoBehaviour
{
    public string sujet; 
    public string filesujet;
    public int id;
    public int st;
    public Chara_move chara;
    

    void Update()
    {
        chara = GameObject.FindWithTag("Player").GetComponent<Chara_move>();
        if (PlayerPrefs.GetInt(sujet,0) == id)
        {
            chara.poza = 0;
            Directory.CreateDirectory("save");
            File.WriteAllText(@"save/" + filesujet, st.ToString());
        }
        
    }
}
