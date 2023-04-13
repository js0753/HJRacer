using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour {

	public int ModeSelection;
	public GameObject RaceModeUI;
	public GameObject AICar;
	// Use this for initialization
	void Start () {
		ModeSelection = ModeSelect.RaceMode;
		if (ModeSelection == 1) {
			RaceModeUI.SetActive (false);
			AICar.SetActive (false);
		}
	}

}
