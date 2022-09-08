using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class console : MonoBehaviour
{
    public InputField ifd;
    bool isloadind;
    float tic;
    public save_suniverse ss = new save_suniverse();
    public void load()
    {
        ifd.text = "";
        isloadind = true;
        if (tic >= 4)
        {
            ifd.text = "сохранение #с распознано!)\n";
        }
        if (tic >= 6)
        {
            ifd.text = "открываем сцнну ss/_save.json::scene.int\n";
        }
        if (tic >= 8)
        {
            if (File.Exists("ss/_save.json"))
            {
                ss = JsonUtility.FromJson<save_suniverse>(File.ReadAllText("ss/_save.json"));
                save_suniverse.insystem = true;
                ss.load(ss.scene);
            }
            else
            {
                ss.load(1);
            }
        }

    }
    private void Update()
    {

        tic += Time.deltaTime;
        if (isloadind)
        {
            load();
        }
        if (ifd.text.Length != 0 && Input.GetKeyDown(KeyCode.Return) && !isloadind)
        {
            load();
        }
    }
}
