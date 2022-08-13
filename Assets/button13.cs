using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class button13 : MonoBehaviour
{
    public string sujet;
    public int id;
    public bool type;
    void OnTriggerEnter2D(Collider2D s)
    {
        
        if (s.gameObject.tag == "Player")
        {
            

                Debug.Log("1");
                s.gameObject.GetComponent<Chara_move>().poza = 1;
                PlayerPrefs.SetInt(sujet, id);
            

        }
    }
}
