using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class save3 : MonoBehaviour {
    public GameObject player1;
    public float ypos1;
    public float zpos1;
    public float xpos1;
    public int word;



    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("SUJET4", 0) != 1)
        {
            player1.transform.position = new Vector3(PlayerPrefs.GetFloat("xx2" + gameObject.name + word, transform.position.x), PlayerPrefs.GetFloat("yy2" + gameObject.name + word, transform.position.y), PlayerPrefs.GetFloat("zz2" + gameObject.name + word, transform.position.z));

        }

    }

    // Update is called once per frame
    void Update()
    {




        if (PlayerPrefs.GetInt("SUJET4", 0) != 1)
        {
            zpos1 = transform.position.z;

            xpos1 = transform.position.x;


            ypos1 = transform.position.y;

            PlayerPrefs.SetFloat("xx2" + gameObject.name + word, xpos1);
            PlayerPrefs.SetFloat("zz2" + gameObject.name + word, zpos1);
            PlayerPrefs.SetFloat("yy2" + gameObject.name + word, ypos1);
        }


    }
    public void rtt()
    {

    }
        
    public void rtt2()  
    {
            player1.transform.position = new Vector3(PlayerPrefs.GetFloat("xx2" + gameObject.name + word), PlayerPrefs.GetFloat("yy2" + gameObject.name + word), PlayerPrefs.GetFloat("zz2" + gameObject.name + word));
    }
    
}
