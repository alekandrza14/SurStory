using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class igrok : MonoBehaviour
{
    public int hp = 10;
    public bool fight;
    public Text txt;

    private void Start()
    {
        if (File.Exists(@"save/save1"))
        {
            if (!File.Exists(@"save/undyne"))
            {
                if (File.ReadAllText(@"save/save1") == "1")
                {
                    hp = 20;
                }
                else if (File.ReadAllText(@"save/save1") == "2")
                {
                    hp = 30;
                }
            }



            else
            {
                hp = 30;
            }
        }
    }
    void Update()
    {
        txt.text = hp.ToString();
        if (hp <= 0)
        {
            PlayerPrefs.DeleteKey("level");
            SceneManager.LoadScene(0);
        }
    }
    public void fight1()
    {
        fight = true;
    }
    public void attack()
    {

    }
    
}
