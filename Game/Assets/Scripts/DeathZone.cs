using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	void Update ()
    {
		
        if(transform.position.y<0)
        {

            LiveManager.killPlayer(gameObject);

        }

	}
}
