using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete1 : MonoBehaviour
{
    public string test;
    void Update()
    {
        if (PlayerPrefs.GetInt(test, 0) == 1)
        {
            Destroy(gameObject);
        } 
    }
}
