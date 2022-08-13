using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forse : MonoBehaviour
{
    public bool vc;
    void Update()
    {
        if (!vc)
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        if (vc)
        {
            transform.position -= new Vector3(0.1f, 0, 0);
        }
    }
}
