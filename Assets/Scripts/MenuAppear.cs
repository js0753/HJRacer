using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour {

	public GameObject largeButton;
	public GameObject menuButtons;

	
	public void StartMenu(){
		menuButtons.SetActive (true);
		largeButton.SetActive (false);
	}
}
