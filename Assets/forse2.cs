using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forse2 : MonoBehaviour
{
    public bool vc; 
    public bool vc3;
    public Vector2 vc2;
    public Vector2 vc21;
    private void Start()
    {
        
        vc21 = new Vector2(transform.position.x, transform.position.y);
    }
    void Update()
    {
        vc2 = new Vector2(transform.position.x, transform.position.y);
        if (vc2.y >= vc21.y + 10)
        {
            vc3 = true;
        }
        if (vc2.y <= vc21.y - 10)
        {
            vc3 = false;
        }
        if (vc3 == true)
        {
            transform.position -= new Vector3(0, Random.Range(0.001f, 0.5f), 0);
        }
        if (vc3 == false)
        {
            transform.position += new Vector3(0, Random.Range(0.001f, 0.5f), 0);
        }
        if (!vc)
       {
            transform.position += new Vector3(0.05f, 0, 0);
        }
       if (vc)
       {
           transform.position -= new Vector3(0.05f, 0, 0);
        }
    }
}
