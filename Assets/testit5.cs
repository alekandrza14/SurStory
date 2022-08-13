using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class testit5 : MonoBehaviour
{
    public string sujet; 
    public string filesujet;
    public int id;
    public int st;
    public Chara_move chara;
    public int sceneid;
    

    void Update()
    {
        chara = GameObject.FindWithTag("Player").GetComponent<Chara_move>();
        if (File.Exists(@"save/" + filesujet))
        {
            if (File.ReadAllText(@"save/" + filesujet) == "3")
            {
                chara.poza = 0;
                SceneManager.LoadScene(sceneid);
                File.WriteAllText(@"save/" + filesujet, st.ToString() + 1);
            }
        }
        
    }
}
