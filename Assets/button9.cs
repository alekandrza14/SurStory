using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class button9 : MonoBehaviour
{
    public string sujet;
    public int id;
    public bool type;
    void OnTriggerEnter2D(Collider2D s)
    {
        
        if (s.gameObject.tag == "Player")
        {
            if (!File.Exists(@"save/undyne"))
            {
                if (PlayerPrefs.GetInt("papayrus", 0) != 1)
                {
                    
                    Debug.Log("1");
                    PlayerPrefs.SetInt("fighting", 0);
                    s.gameObject.GetComponent<Chara_move>().poza = 1;
                    PlayerPrefs.SetInt(sujet, id);
                }
            }

        }
    }
}
