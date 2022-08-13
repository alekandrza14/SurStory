using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class button8 : MonoBehaviour
{
    public bool but;
    public Animator anim;
    public bool type;
    void OnTriggerEnter2D(Collider2D s)
    {
        
        if (s.gameObject.tag == "Player")
        {
            if (type == true)
            {

                if (!anim)
                {
                    anim = GetComponent<Animator>();
                    
                    anim.SetBool("but", true);
                    PlayerPrefs.SetInt("SUJET2", 1);
                    
                    
                    
                    
                }


            }
            if (type == false)
            {
                if (!anim)
                {
                    anim = GetComponent<Animator>();
                    anim.SetBool("but", true);
                    PlayerPrefs.SetInt("SUJET2", 0);
                }
            }
        }
    }
}
