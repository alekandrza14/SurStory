using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete2 : MonoBehaviour
{
    
    void Update()
    {
        if (PlayerPrefs.GetInt("iy2", 0) == 1)
        {
            Destroy(gameObject);
        } 
    }
}
