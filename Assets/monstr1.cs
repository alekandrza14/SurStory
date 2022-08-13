using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class monstr1 : MonoBehaviour
{
    public GameObject player;
    public Transform[] position;
    public GameObject[] obj;
    public int tic;
    public int tic2;
    public int time = 20; 
    public int time2 = 1200;
    void Update()
    {
        if (player.GetComponent<igrok>().fight == true)
        {
            tic++;
            tic2++;
            if (tic >= time)
            {
                Instantiate(obj[Random.Range(0,2)], position[Random.Range(0, position.Length)]);
                tic = 0;
            }
            if (tic2 >= time2)
            {
                player.GetComponent<igrok>().fight = false;
                tic2 = 0;
                PlayerPrefs.SetInt("fighting", 1);
                SceneManager.LoadScene(PlayerPrefs.GetInt("level", 1));

            }
        }
    }
    public void tt()
    {
        player.GetComponent<igrok>().fight = false;

        PlayerPrefs.SetInt("fighting", 1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("level", 1));
    }
    public void spare_undyne()
    {
        player.GetComponent<igrok>().fight = false;
        File.WriteAllText(@"save/undyne", "пощада");
        PlayerPrefs.SetInt("fighting", 1);
        SceneManager.LoadScene(50);
    }
}
