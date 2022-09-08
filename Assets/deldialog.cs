﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deldialog : MonoBehaviour
{
    public GameObject button;
    public string del; public string delattack;
    public string[] s = new string[1];
    public string sm = "Очевидно..."; 
    public string[] se = new string[1];
    public string sme = "Очевидно...";
    public TextMeshProUGUI text;
    public Animator anim;
    public bool enter; public bool act;
    public float tic; public int tir; public int tir2;
    public bool stopPlayer;
    public int chargescene;
    public bool deleteing;
    public bool oneraz; public bool oneraz1;
    public bool startActivate;
    public string[] animationsnames; 
    public int cur;
    public int deletedchar;


    void Start()
    {
       tir2 = VarSave.GetInt(del);
        s[0] = text.text;
        VarSave.SetInt("delbutton" + del, 0);
        button.SetActive(false);
        text.text = "";

        if (startActivate)
        {
            button.SetActive(true);
            text.text = "";
                act = true;
                if (anim)
                {
                    anim.SetTrigger(animationsnames[cur]);
                }
            
        }
    }
    public void nabor(string sm, string[] s)
    {
        if (animationsnames.Length < cur) 
        {
            cur = 0;
        }
        if (act && enter)
        {

            tic += 1 * Time.deltaTime;
            if (tic >= 0.1f)
            {
                NewMethod(sm, s);
                if (s.Length > tir2)
                {


                    if (s[tir2].Length > tir)
                    {
                        text.text += s[tir2][tir];
                    }
                }

                else
                {
                    text.text += sm[tir];
                }


                tir += 1;
                NewMethod(sm, s);

                tic = 0;
            }
        }
    }

    private void NewMethod(string sm, string[] s)
    {
        if (s.Length > tir2)
        {
            if (s[tir2].Length <= tir)
            {
                tir2 += 1;
                tir = 0;

                act = false;
            }
        }
        else if (sm.Length <= tir)
        {
            tir2 += 1;
            tir = 0;

            act = false;
        }
        else if (sm.Length <= tir && sm[0] != 's' && sm[1] != '2' && sm[2] != '-')
        {
            tir2 += 1;
            tir = 0;

            act = false;
        }
        else if (sm == "s2-resset()")
        {
            stopPlayer = false;
            tir2 = 0;
            tir = 0;



        }
        else if (sm == "s2-attack()")
        {
            stopPlayer = false;
            tir2 = 0;
            tir = 0;
            VarSave.SetBool(delattack, true);

        }

        else if (sm == "s2-attackforse()")
        {
            stopPlayer = false;


            VarSave.SetBool(delattack, true);

        }
        else if (sm == "s2-attackforse().")
        {
            stopPlayer = false;


            VarSave.SetBool(delattack, true);

        }
        else if (sm == "s2-resset().")
        {
            stopPlayer = false;
            tir2 = 0;
            tir = 0;


        }
        else if (sm == "s2-attack().")
        {
            stopPlayer = false;
            tir2 = 0;
            tir = 0;
            VarSave.SetBool(delattack, true);

        }
        else if (sm == "s2-Shop()")
        {
            stopPlayer = false;
            Instantiate(Resources.Load<GameObject>("ui/shop/" + delattack));
            tir2 = 0;
            tir = 0;
        }

        else if (sm == "s2-Shop().")
        {
            stopPlayer = false;
            Instantiate(Resources.Load<GameObject>("ui/shop/" + delattack));
            tir2 = 0;
            tir = 0;
        }
    }

    void Update()
    {
        if (VarSave.EnterFloat("lenguage_english"))
        {
            nabor(sme,se);
        }
        if (!VarSave.EnterFloat("lenguage_english"))
        {
            nabor(sm, s);
        }
        if (!enter && !startActivate)
        {
            tir = 0;
            text.text = "";
            tic = 0;
            act = false;
        }
        if (ispresed.use && enter)
        {
            text.text = "";
            act = true;
            if (anim)
            {
                anim.SetTrigger("talke");
            }
            ispresed.use = false;
        }
        if (ispresed.use && startActivate)
        {
            text.text = "";
            act = true;
            cur++;
            if (anim)
            {
                anim.SetTrigger(animationsnames[cur]);
            }
            ispresed.use = false;
        }
        if (text.text == "event")
        {

            Instantiate(Resources.Load<GameObject>("вопрос" + delattack));
            text.text = "";
        }
        if (text.text == "event.")
        {

            Instantiate(Resources.Load<GameObject>("вопрос" + delattack));
            text.text = "";
        }
        if (VarSave.GetInt("delbutton" + del) == 1)
        {
            button.SetActive(true);
            
            
        }
        else if(!startActivate)
        {
            button.SetActive(false);
        }
        VarSave.SetInt(del ,tir2);
    }
    private void OnTriggerEnter2D(Collider2D s)
    {
        if (!oneraz1)
        {
            Debug.Log(1);
            if (s.tag == "Player")
            {
               
                enter = true;
                Debug.Log(1);
                VarSave.SetInt("delbutton" + del, 1);
            }
        }
    }
        private void OnTriggerExit2D(Collider2D s)
    {
        if (s.tag == "Player")
        {
            if (oneraz)
            {
                oneraz1 = true;
            }
            enter = false;
            VarSave.SetInt("delbutton" + del, 0);
        }
    }
}
