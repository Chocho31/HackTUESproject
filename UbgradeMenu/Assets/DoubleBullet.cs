using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBullet : MonoBehaviour {

	public GameObject image;
	void OnMouseOver(){
		image.SetActive(true);
	}
	void OnMouseExit(){
		image.SetActive (false);
	}
}
