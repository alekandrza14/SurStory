using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTrigger : MonoBehaviour
{
    public bool enter;

    private void OnCollisionStay2D(Collision2D c)
    {
        if (c.collider.tag == "Player")
        {
            save_suniverse.issave = true;
            enter = true;
        }
    }
    private void OnCollisionExit2D(Collision2D c)
    {
        if (c.collider.tag == "Player")
        {
            save_suniverse.issave = false;
            enter = false;
        }
    }
    private void Update()
    {
        if (ispresed.use && enter)
        {
            save_suniverse.issave = true;
        }
    }
}
