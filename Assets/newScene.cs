using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class newScene : MonoBehaviour
{
    public int cam;

    private void Start()
    {
        cam = PlayerPrefs.GetInt("cam", 0);
    }
    // Update is called once per frame
    public void Newscene()
    {
        if (PlayerPrefs.GetInt("level", 1) == 1)
        {

            SceneManager.LoadScene(PlayerPrefs.GetInt("level1", 1));
        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("level", 1));
        }

        Directory.CreateDirectory("save");
        if (!File.Exists(@"save/fun66.txt"))
        {
            File.WriteAllText(@"save/fun66.txt", "0");
        }
    }
    public void Newscene1()
    {
        
            SceneManager.LoadScene(1);
        
        Directory.CreateDirectory("save");
        if (!File.Exists(@"save/fun66.txt"))
        {
            File.WriteAllText(@"save/fun66.txt", "0");
        }
    }
    public void Newscene2()
    {


        SceneManager.LoadScene(20);



        Directory.CreateDirectory("save");
        if (!File.Exists(@"save/fun66.txt"))
        {
            File.WriteAllText(@"save/fun66.txt", "0");
        }
    }
    public void Newscene3()
    {


        SceneManager.LoadScene(36);



        Directory.CreateDirectory("save");
        if (!File.Exists(@"save/fun66.txt"))
        {
            File.WriteAllText(@"save/fun66.txt", "0");
        }
    }
    public void Newscene4()
    {


        SceneManager.LoadScene(44);



        Directory.CreateDirectory("save");
        if (!File.Exists(@"save/fun66.txt"))
        {
            File.WriteAllText(@"save/fun66.txt", "666");
        }
    }
    public void Newscene5()
    {


        SceneManager.LoadScene(33);



        Directory.CreateDirectory("save");
        if (!File.Exists(@"save/fun66.txt"))
        {
            File.WriteAllText(@"save/fun66.txt", "0");
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void tutorial()
    {
        SceneManager.LoadScene(8);
    }
    public void otions()
    {
        if (cam == 1)
        {
            cam = 0;
        }
        else
        if (cam == 0)
        {
            cam = 1;
        }
        PlayerPrefs.SetInt("cam", cam);
    }
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("error", 1);

        Directory.Delete("save", true);
        
        


    }
}
