using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cl : MonoBehaviour
{
    public SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(Random.Range(0f, 2f),0.1f,0.1f);
    }
   
}
