using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soul_move : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D s)
    {
        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "t")
            {
                player.GetComponent<igrok>().hp -= 1;
            }
        }
        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "tx")
            {
                player.GetComponent<igrok>().hp -= 2;
            }
        }
        if (player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "tm")
            {
                if (Input.GetKey(KeyCode.W))
                {
                    player.GetComponent<igrok>().hp -= 1;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    player.GetComponent<igrok>().hp -= 1;
                }
                if (Input.GetKey(KeyCode.D))
                {
                    player.GetComponent<igrok>().hp -= 1;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    player.GetComponent<igrok>().hp -= 1;
                }
            }
        }
        if(player.GetComponent<igrok>().fight == true)
        {
            if (s.gameObject.tag == "tz")
            {
                if (!Input.GetKey(KeyCode.W))
                {

                    if (!Input.GetKey(KeyCode.S))
                    {


                        if (!Input.GetKey(KeyCode.D))
                        {


                            if (!Input.GetKey(KeyCode.A))
                            {
                                player.GetComponent<igrok>().hp -= 1;
                            }
                        }
                    }
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (player.GetComponent<igrok>().fight == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0.1f, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -0.1f, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0.1f, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-0.1f, 0, 0);
            }
        }
    }
}
