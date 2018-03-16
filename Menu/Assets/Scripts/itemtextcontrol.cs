using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemtextcontrol : MonoBehaviour {

    public Transform PopUpText;
    public static string TextStatus = "off";
    public GameObject health;
    

	void OnMouseEnter()
    {
        if(TextStatus=="off")
        {

            health.SetActive(false);
            PopUpText.GetComponent<TextMesh>().text="A Bomb\nA0E consumable\n20 Base Damage";
            TextStatus = "on";
            Instantiate(PopUpText, new Vector3(transform.position.x, transform.position.y + 2, 0), PopUpText.rotation);
            
        }
    }

    void OnMouseExit()
    {
        if (TextStatus == "on")
        {
            health.SetActive(true);
            Instantiate(PopUpText, new Vector3(transform.position.x, transform.position.y + 2, 0), PopUpText.rotation);
        }
    }
}
