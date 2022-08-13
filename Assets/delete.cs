using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    
    void Update()
    {
        if (PlayerPrefs.GetInt("iy", 0) == 1)
        {
            Destroy(gameObject);
        } 
    }
}
