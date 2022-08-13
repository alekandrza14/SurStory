using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyy : MonoBehaviour
{
    public int tic;
    void Update()
    {
        tic++;
        if (tic >= 200)
        {
            Destroy(gameObject);
            tic = 0;
        }
    }
}
