using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialog7 : MonoBehaviour {
    public Text txt;
    public Image panel;
    public string dialog2;
    public string dialog3;
    public string dialog4;
    public string dialog5;
    public string dialog6;
    public bool Enter;
    public int time = 0;
    public bool s;
    public string sujet;

    public int score;
    public int score2;
    public int score3;
    public int score4;
    public int score5;
    public int scorem1;


    public int Sujet; 
    public int Sujet2; 
    public int Sujet3;
    public int Sujet4; 
    public int Sujetm1;





    private void Start()
    {
        txt = GameObject.Find("2").GetComponent<Text>(); 
        panel = GameObject.Find("1").GetComponent<Image>();


    }
    void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            txt.text = "";
            if (PlayerPrefs.GetInt("SUJET", 0) == scorem1)
            {
                txt.text = dialog2;
            }
                panel.enabled = true;
            Enter = true;
        }
    }
    void OnTriggerExit2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            txt.text = " ";
            panel.enabled = false;
            Enter = false;
        }
    }
    public void Update()
    {
        
        


        if (Enter == true)
        {
            if (PlayerPrefs.GetInt("SUJET", 0) == scorem1)
            {
                if (PlayerPrefs.GetInt(sujet, 0) == score)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        txt.text = dialog3;
                        PlayerPrefs.SetInt(sujet, Sujet);
                    }



                }
                else if (PlayerPrefs.GetInt(sujet, 0) == score2)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        txt.text = dialog4;
                        PlayerPrefs.SetInt(sujet, Sujet2);
                    }



                }
                else if (PlayerPrefs.GetInt(sujet, 0) == score3)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        txt.text = dialog5;
                        PlayerPrefs.SetInt(sujet, Sujet3);
                    }



                }
                else if (PlayerPrefs.GetInt(sujet, 0) == score4)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        txt.text = dialog6;
                        PlayerPrefs.SetInt(sujet, Sujet4);
                        PlayerPrefs.SetInt("SUJET", Sujetm1);

                    }



                }
                else if (PlayerPrefs.GetInt(sujet, 0) == score5)
                {

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("1");
                        txt.text = dialog6;
                        PlayerPrefs.SetInt("SUJET", Sujetm1);

                    }



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
