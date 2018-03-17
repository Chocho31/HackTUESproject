using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryMenuScript : MonoBehaviour {

	public void Back_Button() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}
	public void Equip_Button() {
		return;
	}
}
