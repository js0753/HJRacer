﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalCash : MonoBehaviour {

	public int CashValue;
	public static int TotalCash;
	public GameObject CashDisplay;
	// Use this for initialization
	void Start () {
		TotalCash = PlayerPrefs.GetInt ("SavedCash");
	}
	
	// Update is called once per frame
	void Update () {
		CashValue = TotalCash;
		CashDisplay.GetComponent<Text> ().text = "Cash $"+CashValue; // <> is used to represent Generic Type parameter
	}
}
