using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testit6 : MonoBehaviour
{
    public string sujet;
    public int id;
    public Chara_move chara;
    
    private ElementalInventory inventory;

    void Update()
    {
        if (inventory == null)
        {
            inventory = FindObjectOfType(typeof(ElementalInventory)) as ElementalInventory;
        }
        chara = GameObject.FindWithTag("Player").GetComponent<Chara_move>();
        if (PlayerPrefs.GetInt(sujet,0) == id)
        {
            give("medal", 1, new Color(0, 0, 0.1f));
            chara.poza = 0;
            PlayerPrefs.SetInt(sujet, 0);
        }
        
    }
    public void give(string name, int count, Color col)
    {
        for (int j = 0; j < 31; j++)
        {
            for (int j1 = 0; j1 < 31; j1++)
            {

                if (inventory.Cells[j1].elementCount == 0)
                {

                    inventory.Cells[j1].elementName = "none";
                    inventory.Cells[j1].elementColor = new Color(0, 0, 0);
                    inventory.Cells[j1].UpdateCellInterface();
                }
            }
            if (inventory.Cells[j].elementName == "none" && inventory.Cells[j].elementColor == new Color(0, 0, 0) && inventory.Cells[j].elementName != name && inventory.Cells[j].elementColor != col && inventory.Cells[j].elementCount <= 0)
            {



                inventory.setItem(name, count, col, j);
                Debug.Log("отданно");
                j = 31;


            }
            else if (inventory.Cells[j].elementName == name && inventory.Cells[j].elementColor == col && inventory.Cells[j].elementCount >= 0 && inventory.Cells[j].elementCount < 100)
            {
                inventory.Cells[j].elementCount += 1;
                inventory.Cells[j].UpdateCellInterface();
                Debug.Log("отданно 2");
                j = 31;
            }
            else if (inventory.Cells[j].elementName == name && inventory.Cells[j].elementColor == col && inventory.Cells[j].elementCount >= 0 && inventory.Cells[j].elementCount < 100)
            {
                if (j < 30)
                {
                    if (inventory.Cells[j + 1].elementName == "none" && inventory.Cells[j + 1].elementColor == new Color(0, 0, 0) && inventory.Cells[j + 1].elementCount <= 0)
                    {
                        inventory.setItem(name, count, col, j + 1);
                        inventory.Cells[j].UpdateCellInterface();
                        Debug.Log("отданно 3");
                        j = 31;
                    }
                }
            }
        }
    }
}
