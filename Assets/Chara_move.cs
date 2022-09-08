using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class save_suniverse_scene
{
    public Vector3 pos;

}
public class save_suniverse
{
    public int scene;
    public static bool insystem;
    public static bool ineditor;
    public static bool issave;
    public void load(int i)
    {
        SceneManager.LoadScene(i);
    }
}

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
    public save_suniverse_scene sss = new save_suniverse_scene();
    public save_suniverse ss = new save_suniverse();

    void Start()
    {
#if UNITY_EDITOR
        save_suniverse.ineditor = true;
#endif
        sr = GetComponent<SpriteRenderer>();
        rig = GetComponent<Rigidbody2D>();
        time3 = PlayerPrefs.GetInt("time", 0);
        if (File.Exists("sss/_" + SceneManager.GetActiveScene().buildIndex + "/save.json") && save_suniverse.insystem)
        {
            sss = JsonUtility.FromJson<save_suniverse_scene>(File.ReadAllText("sss/_" + SceneManager.GetActiveScene().buildIndex + "/save.json"));
            transform.position = sss.pos;
            if (true)
            {


                save_suniverse.insystem = false;
            }
        }
        if (File.Exists("sss/_" + SceneManager.GetActiveScene().buildIndex + "/save.json") && save_suniverse.ineditor)
        {
            Debug.Log("ус");
            sss = JsonUtility.FromJson<save_suniverse_scene>(File.ReadAllText("sss/_" + SceneManager.GetActiveScene().buildIndex + "/save.json"));
            transform.position = sss.pos;
            if (true)
            {
                save_suniverse.ineditor = false;
            }
        }
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
        if (save_suniverse.issave)
        {


            sss.pos = transform.position;
            Directory.CreateDirectory("sss/_" + SceneManager.GetActiveScene().buildIndex);
            File.WriteAllText("sss/_" + SceneManager.GetActiveScene().buildIndex + "/save.json", JsonUtility.ToJson(sss));
            ss.scene = SceneManager.GetActiveScene().buildIndex;
            Directory.CreateDirectory("ss/_");
            File.WriteAllText("ss/" + "_save.json", JsonUtility.ToJson(ss));
            save_suniverse.issave = false;
        }


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
