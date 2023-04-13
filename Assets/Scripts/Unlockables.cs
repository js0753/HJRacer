using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlockables : MonoBehaviour {

	public GameObject greenButton;
	public int CashValue;
	public int greenUnlocked;
	void Start(){
		
		greenUnlocked = PlayerPrefs.GetInt ("GreenUnlocked");
		if (greenUnlocked == 1) {
			greenButton.SetActive (false);
		}
	}
	void Update () {
		CashValue = GlobalCash.TotalCash;
		if (greenUnlocked==0 && CashValue >= 100) {
			greenButton.GetComponent<Button> ().interactable = true;
		}
	}

	public void greenUnlock(){
		greenButton.SetActive (false);
		GlobalCash.TotalCash -= 100;
		PlayerPrefs.SetInt ("SavedCash", GlobalCash.TotalCash);
		PlayerPrefs.SetInt ("GreenUnlocked", greenUnlocked);
		PlayerPrefs.Save ();
	}
}
