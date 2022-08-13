using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyy1 : MonoBehaviour
{
    public int tic;
    void Update()
    {
        tic++;
        if (tic >= 500)
        {
            Destroy(gameObject);
            tic = 0;
        }
    }
}
