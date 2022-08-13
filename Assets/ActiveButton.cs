using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ispresed
{
   public static bool use;
}


public class ActiveButton : MonoBehaviour
{
    public float tic;
    public void click()
    {
        ispresed.use = true;
        Instantiate(Resources.Load<GameObject>("use"));
    }
    private void Update()
    {
        if (ispresed.use)
        {
            tic += Time.deltaTime;
            if (tic > 1)
            {
                ispresed.use = false;
            } 
        }
    }
}
