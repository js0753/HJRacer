using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour {

	public int ModeSelection;
	public GameObject RaceModeUI;
	public GameObject ScoreModeUI;
	public GameObject ScoreText;
	public GameObject AICar;
	public static int CurrentScore;
	public int InternalScore;
	public GameObject ScoreObjects;
	// Use this for initialization
	void Start () {
		ModeSelection = ModeSelect.RaceMode;
		if (ModeSelection == 1) {
			RaceModeUI.SetActive (false);
			ScoreModeUI.SetActive (true);
			ScoreObjects.SetActive (true);
			AICar.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		InternalScore = CurrentScore;
		ScoreText.GetComponent<Text> ().text = ""+InternalScore;
	}
}
