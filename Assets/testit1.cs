using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testit1 : MonoBehaviour
{
    public string sujet;
    public int id;
    public int id2;
    public int sceneid;
    public Chara_move chara;
    public int time2 = 20;
    public int time = 20;
    public int timer = 0;
    public SpriteRenderer sr;
    public Sprite[] anim;
    public GameObject g;
    void Update()
    {
        if (chara == null)
        {

            chara = GameObject.FindWithTag("Player").GetComponent<Chara_move>();
            sr = gameObject.GetComponent<SpriteRenderer>();
        }
            if (chara != null && sr != null)
            {
            timer++;

                if (PlayerPrefs.GetInt(sujet, 0) == id)
                {
                    if (chara.gameObject.transform.position.x - 1 <= transform.position.x)
                    {
                     //   chara.poza = 0;
                        PlayerPrefs.SetInt(sujet, id2);
                    }
                    if (chara.gameObject.transform.position.x - 1 >= transform.position.x)
                    {
                       // PlayerPrefs.SetInt(sujet, id);
                        chara.poza = 1;
                        transform.position += new Vector3(0.1f,0,0);
                    g.transform.position = transform.position;
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
                }


            }
    }
}
