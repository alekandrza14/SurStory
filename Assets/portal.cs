using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portallNumer
{
    public static bool p1 = false;
    public static bool p2 = false;
    public static bool p3 = false;
    public static bool p4 = false;
    public static bool p5 = false;
    public static bool p6 = false;
    public static bool p7 = false;
    public static bool p8 = false;
}

public class portal : MonoBehaviour
{
    public int id;
    public bool enter;
    public bool iaw;
    public bool p3;
    public bool p4;
    public bool p5;
    private void Start()
    {
        if (portallNumer.p2 == true && iaw)
        {
            FindObjectOfType<Chara_move>().transform.position = transform.position;
            portallNumer.p2 = false;
        }
        if (portallNumer.p3 == true && p3)
        {
            FindObjectOfType<Chara_move>().transform.position = transform.position;
            portallNumer.p3 = false;
        }
        if (portallNumer.p4 == true && p4)
        {
            FindObjectOfType<Chara_move>().transform.position = transform.position;
            portallNumer.p4 = false;
        }
        if (portallNumer.p5 == true && p5)
        {
            FindObjectOfType<Chara_move>().transform.position = transform.position;
            portallNumer.p5 = false;
        }

    }
    public void startcol()
    {
        enter = true;

    }

    private void OnTriggerEnter2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {

            startcol();



        }
    }

    void Update()
    {
        if (ispresed.use)
        {
            if (enter && iaw)
            {
                
                portallNumer.p2 = true;
                ispresed.use = false;
                SceneManager.LoadScene(id);

            }
            if (enter && p3)
            {
                
                portallNumer.p3 = true;

                ispresed.use = false;
                SceneManager.LoadScene(id);
            }
            if (enter && p4)
            {
                portallNumer.p4 = true;

                ispresed.use = false;
                SceneManager.LoadScene(id);
            }
            if (enter && p5)
            {
                
                portallNumer.p5 = true;

                ispresed.use = false;
                SceneManager.LoadScene(id);

            }
            if (enter)
            {

                ispresed.use = false;
                SceneManager.LoadScene(id);

            }
        }
    }
    private void OnTriggerExit2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {

            enter = false;


        }
    }
}

