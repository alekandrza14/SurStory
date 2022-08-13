using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialog13 : MonoBehaviour {
    public Text txt;
    public Image panel;
    public string[] dialog;
    
    public bool Enter;
    public int time = 0;
    public bool s;
    public string sujet;
    public Font reload;
    public Font reload2;

    public int score;
    public int maxscore;




    public int[] Sujet; 
     






    private void Start()
    {
        txt = GameObject.Find("2").GetComponent<Text>(); 
        panel = GameObject.Find("1").GetComponent<Image>();


    }
    void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {

            PlayerPrefs.SetInt(sujet, -1);
            score = -1;
            if (PlayerPrefs.GetInt(sujet, 0) == score)
            {
                txt.text = dialog[0];
            }
            txt.font = reload;
            panel.enabled = true;
            Enter = true;
        }
    }
    void OnTriggerExit2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            txt.font = reload2;
            txt.text = " ";
            panel.enabled = false;
            Enter = false;
        }
    }
    public void Update()
    {
        if (score > maxscore)
        {
            score = maxscore;
        }
        


        if (Enter == true)
        {
            if (PlayerPrefs.GetInt(sujet, 0) == score)
            {
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    score++;
                    txt.text = dialog[score];
                    PlayerPrefs.SetInt(sujet,Sujet[score]);
                }



            }
            
            
           



            
        }
    }
    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("SUJET",0) == 1) 
        { 

            
  
        }

    }
}
