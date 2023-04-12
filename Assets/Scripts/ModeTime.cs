using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class ModeTime : MonoBehaviour {

	public int ModeSelection;
	public GameObject RaceModeUI;
	public GameObject TimeModeUI;
	public GameObject CountdownMilli;
	public GameObject CountdownSec;
	public GameObject CountdownMin;
	public GameObject AICar;
	public GameObject LapRequirement;
	public static float TimeRemaining;
	public int MinuteCount;
	public int SecondCount;
	public float MilliCount;



	public GameObject MyCar;
	public GameObject CarCam;
	public GameObject FinishCam;
	public GameObject LevelMusic;
	public GameObject MiniMap;
	public float countdown;
	// Use this for initialization
	void Start () {
		ModeSelection = ModeSelect.RaceMode;
		if (ModeSelection == 2) {
			TimeRemaining = 600;
			MinuteCount = (int)TimeRemaining / (60 * 10);
			SecondCount = ((int)TimeRemaining - MinuteCount * 600)/10;
			MilliCount = TimeRemaining - MinuteCount * 600 - SecondCount * 10;
			RaceModeUI.SetActive (false);
			TimeModeUI.SetActive (true);
			AICar.SetActive (false);
			LapRequirement.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		countdown += Time.deltaTime;
		Debug.Log (ModeSelection);
		if (countdown>=3 && ModeSelection == 2) {
			TimeRemaining -= Time.deltaTime * 10;

			if ((int)TimeRemaining >= 0) {
				MinuteCount = (int)TimeRemaining / (60 * 10);
				SecondCount = ((int)TimeRemaining - MinuteCount * 600)/10;
				MilliCount = TimeRemaining - MinuteCount * 600 - SecondCount * 10;
				CountdownMilli.GetComponent<Text> ().text = "" + MilliCount;

				if (SecondCount <= 9) {
					CountdownSec.GetComponent<Text> ().text = "0" + SecondCount + ".";
				} else {
					CountdownSec.GetComponent<Text> ().text = "" + SecondCount + ".";
				}
				if (MinuteCount <= 9) {
					CountdownMin.GetComponent<Text> ().text = "0" + MinuteCount + ":";
				} else {
					CountdownMin.GetComponent<Text> ().text = "" + MinuteCount + ":";
				}

			} else {
				MyCar.SetActive (false);
				CarController.m_Topspeed = 0.0f;
				MyCar.GetComponent<CarController> ().enabled = false;
				MyCar.GetComponent<CarUserControl> ().enabled = false;
				MyCar.SetActive (true);
				FinishCam.SetActive (true);
				LevelMusic.SetActive (false);
				CarCam.SetActive (false);
				MiniMap.SetActive (false);
				this.enabled = false;
			}
		}
	}
}
