using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;



public class button3 : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D s)
    {

        if (s.gameObject.tag == "Player")
        {
            if (File.Exists(@"save/save1"))
            {
                if (File.ReadAllText(@"save/save1") == "")
                {
                    File.WriteAllText(@"save/save1", "1");

                }
            }
            else
            {
                Directory.CreateDirectory("save");
                File.WriteAllText(@"save/save1", "1");
            }
        }
    }
}
