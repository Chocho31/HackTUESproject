using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour {
	public GameObject image;
	void OnMouseOver(){
		Debug.Log ("Hello");
		image.SetActive(true);
	}
	void OnMouseExit(){
		image.SetActive (false);
	}
}
