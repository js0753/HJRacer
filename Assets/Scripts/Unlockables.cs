using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unlockables : MonoBehaviour {

	public GameObject greenButton;
	public int CashValue;

	void Update () {
		CashValue = GlobalCash.TotalCash;
		if (CashValue >= 100) {
			greenButton.GetComponent<Button> ().interactable = true;
		}
	}

	public void greenUnlock(){
		greenButton.SetActive (false);
		GlobalCash.TotalCash -= 100;
		PlayerPrefs.SetInt ("SavedCash", GlobalCash.TotalCash);
		PlayerPrefs.SetInt ("GreenUnlocked", 1);
		PlayerPrefs.Save ();
	}
}
