using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public bool t;
    public float f;
    void OnTriggerEnter2D(Collider2D s)
    {

        if (s.gameObject.tag == "Player")
        {

            if (t)
            {
                s.gameObject.transform.position -= new Vector3(0, f,0);
            }
            else
            {
                s.gameObject.transform.position += new Vector3(0,f,0);
            }
        }
    }
}
