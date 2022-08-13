using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_move : MonoBehaviour
{
    
    public Rigidbody2D rig;
    
    public int rotation;
    public SpriteRenderer sr;
    public Sprite[] anim;
    public int timer;
    public int time;
    public int time2;
    public int time3;
    public int poza;
    public GameObject jo;
    bool ismowe;
    public float speed;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rig = GetComponent<Rigidbody2D>();
        time3 = PlayerPrefs.GetInt("time", 0);
    }

    
    void Update()
    {
        time3++;
        rig.velocity = Vector2.zero;
        PlayerPrefs.SetInt("time", time3);
        if(time3 >= 1500)
        {
            PlayerPrefs.SetInt("fighting", 0);
            time3 = 0;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        timer++;
      
       
           
            
                rig.velocity += new Vector2(jo.transform.localPosition.x * speed, jo.transform.localPosition.y * speed);
           
            
      
        if (jo.transform.localPosition.y <= -40)
        {
            ismowe = true;
                rotation = 1;
                
        }
        if (!Input.GetKey(KeyCode.Mouse0))
        {
            ismowe = false;
            rig.velocity = new Vector2(0, 0);
            
        }
        if (jo.transform.localPosition.y >= 40)
        {
            ismowe = true;
            rotation = 4;
                
        }
        
        if (jo.transform.localPosition.x >= 40)
        {
            ismowe = true;
            rotation = 3;
                
        }
      
            if (jo.transform.localPosition.x <= -40)
            {
              
                rotation = 2;

            ismowe = true;

        }
           
        if (rotation == 1)
        {

            if (ismowe)
            {
                sr.flipX = false;
                if (timer >= time && timer <= time2)
                {
                    sr.sprite = anim[0];
                }
                else if (timer >= time2)
                {
                    sr.sprite = anim[1];
                    timer = 0;
                }
            }

            else if (!ismowe)
            {
                sr.flipX = false;
                sr.sprite = anim[2];
            }
        }
        if (rotation == 2)
        {

            if (ismowe)
            {
                sr.flipX = true;
                if (timer >= time && timer <= time2)
                {
                    sr.sprite = anim[3];
                }
                else if (timer >= time2)
                {
                    sr.sprite = anim[4];
                    timer = 0;
                }
            }

            else if (!ismowe)
            {
                sr.flipX = true;
                sr.sprite = anim[5];
            }
        }
        if (rotation == 3)
        {

            if (ismowe)
            {
                sr.flipX = false;
                if (timer >= time && timer <= time2)
                {
                    sr.sprite = anim[6];
                }
                else if (timer >= time2)
                {
                    sr.sprite = anim[7];
                    timer = 0;
                }
            }

            else if (!ismowe)
            {
                sr.flipX = false;
                sr.sprite = anim[8];
            }
        }
        if (rotation == 4)
        {

            if (ismowe)
            {
                sr.flipX = false;
                if (timer >= time && timer <= time2)
                {
                    sr.sprite = anim[9];
                }
                else if (timer >= time2)
                    
                {
                    sr.sprite = anim[10];
                    timer = 0;
                }
            }

            else if (!ismowe)
            {
                sr.flipX = false;
                sr.sprite = anim[11];
            }
        }
    }
}
