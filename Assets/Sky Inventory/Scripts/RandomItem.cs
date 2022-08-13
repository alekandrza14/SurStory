using UnityEngine;
using System.Collections;
using System.IO;

public class RandomItem : MonoBehaviour {

	private ElementalInventory inventory;
    public int time;
    private void Start()
    {
        Directory.CreateDirectory("save");
        if (inventory == null)
        {
            inventory = FindObjectOfType(typeof(ElementalInventory)) as ElementalInventory;
        }
        if (PlayerPrefs.GetString("EInventory") != null)
        {
            if (File.Exists(@"Save/save1.un"))
            {


                PlayerPrefs.SetString("EInventory", File.ReadAllText(@"Save/save1.un"));
            }
            inventory.loadFromString(PlayerPrefs.GetString("EInventory"));
            
        }
        


    }
    void Update ()
    {

        time++;
        
        if (inventory == null) {
			inventory = FindObjectOfType (typeof(ElementalInventory)) as ElementalInventory;
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			inventory.addItem (SimpleMethods.randomElement(), Random.Range(1, inventory.maxStack), new Color(Random.value/2f, Random.value/2f, Random.value/2f, 1f));
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			inventory.clear ();
		}
        PlayerPrefs.SetString("EInventory", inventory.convertToString());
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerPrefs.SetString("EInventory", inventory.convertToString());
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            
            give("loh",1,new Color(0,0,0.1f));
        }
        if (Input.GetKeyDown (KeyCode.L)) {
			inventory.loadFromString (PlayerPrefs.GetString("EInventory"));
		}
		if (Input.GetKeyDown (KeyCode.CapsLock)) {
			inventory.gameObject.SetActive (false);
		}
		if (Input.GetKeyDown (KeyCode.Tab)) {
			inventory.gameObject.SetActive (true);
		}
        if (time >= 1 && time <= 1)
        {
            inventory.gameObject.SetActive(false);
        }
        File.WriteAllText(@"Save/save1.un", PlayerPrefs.GetString("EInventory", ""));
        PlayerPrefs.SetString("EInventory", File.ReadAllText(@"Save/save1.un"));
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
