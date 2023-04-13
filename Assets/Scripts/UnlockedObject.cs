using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObject : MonoBehaviour {

	public int greenUnlocked;
	public GameObject fakeGreen;
	// Use this for initialization
	void Start(){

		greenUnlocked = PlayerPrefs.GetInt ("GreenUnlocked");
		if (greenUnlocked == 1) {
			fakeGreen.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
