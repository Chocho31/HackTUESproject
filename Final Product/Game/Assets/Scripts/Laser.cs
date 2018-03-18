using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    
    GameObject HM;
    HeartManagment heartManager;




    void Awake()
    {
  

        HM = GameObject.FindGameObjectWithTag("MainCamera");
        heartManager = HM.GetComponent<HeartManagment>();
    }




    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="colliderForBullets")
        {
            heartManager.Hide();
        }
    }
}

