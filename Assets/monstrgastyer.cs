using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class monstrgastyer : MonoBehaviour
{
    public GameObject player;
    public Transform[] position; 
    public Transform[] position2;
    public Transform[] position3;
    public Transform[] position4;
    public GameObject obj;
    public int tic;
    public int tic2;
    public int tic3; 
    public int tic4;
    public int time = 20;
    public int time2 = 1200;
    public int time34 = 3;
    public int time32 = 1;
    public int time33 = 2;
    private void Start()
    {
        if (File.Exists(@"save/undyne"))
        {
            if (File.ReadAllText(@"save/undyne") == "пощада")
            {
                player.GetComponent<igrok>().hp = 120;
            }
        }
    }
    void Update()
    {
        tic4++;
        if (tic4 >= 1 && tic4 <= 2)
        {


            if (File.Exists(@"save/undyne"))
            {
                if (File.ReadAllText(@"save/undyne") == "пощада")
                {
                    player.GetComponent<igrok>().hp = 120;
                }
            }

        }        
        if (tic2 >= time2 && tic3 >= time34)
        {
            player.GetComponent<igrok>().fight = false;

            PlayerPrefs.SetInt("fighting", 1);
            SceneManager.LoadScene(PlayerPrefs.GetInt("level", 1));
            tic3++;
            tic3 = 0;
            tic2 = 0;

        }
        if (tic2 >= time2)
        {

            player.GetComponent<igrok>().fight = false;
            tic2 = 0;
            tic3++;


        }
        
        if (tic2 >= time2 && tic3 >= time32)
        {
            player.GetComponent<igrok>().fight = false;
            tic3++;
            tic2 = 0;
            
        }
        if (tic2 >= time2 && tic3 >= time33)
        {
            player.GetComponent<igrok>().fight = false;
            tic3++;
            tic2 = 0;
            

        }
        if (player.GetComponent<igrok>().fight == true)
        {
            tic++;
            tic2++;
            if (tic >= time && tic3 >= 0 && position.Length != 0)
            {
                Instantiate(obj, position[Random.Range(0, position.Length)]);
                tic = 0;
            }
            if (tic >= time && tic3 >= time32 && position2.Length != 0)
            {
                Instantiate(obj, position2[Random.Range(0, position2.Length)]);
                tic = 0;
            }
            if (tic >= time && tic3 >= time33 && position3.Length != 0)
            {
                Instantiate(obj, position3[Random.Range(0, position3.Length)]);
                tic = 0;
            }
            if (tic >= time && tic3 >= time34 && position4.Length != 0)
            {
                Instantiate(obj, position4[Random.Range(0, position4.Length)]);
                tic = 0;
            }
            
            
        }
    }
    
}
