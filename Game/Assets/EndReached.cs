using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndReached : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "End")
        {
            //load next scene
        }
    }
}
