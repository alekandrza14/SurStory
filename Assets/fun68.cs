using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class fun68 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(@"save/fun66.txt"))
        {
            if (File.ReadAllText(@"save/fun66.txt") != "666")
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
