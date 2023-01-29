using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapCompleteTrigger : MonoBehaviour {

	// Use this for initialization
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteBoxBest;
	public GameObject SecondBoxBest;
	public GameObject MilliBoxBest;
	public GameObject LapCount;


	public int MinuteCountBest;
	public int SecondCountBest;
	public float MilliCountBest;
	public string MilliDisplayBest;
	public int LapsDone;

	public bool isBestTime;
	void Start(){
		MinuteCountBest= 9999;
		SecondCountBest= 9999;
		MilliCountBest= 9999;
		Debug.Log (MinuteCountBest);
	}
	void OnTriggerEnter(){
		
		int LTMin = LapTimeManager.MinuteCount;
		int LTSec = LapTimeManager.SecondCount;
		float LTMs = LapTimeManager.MilliCount;

		LapsDone += 1;

		PlayerPrefs.SetInt ("MinSave", LTMin);
		PlayerPrefs.SetInt ("SecSave", LTSec);
		PlayerPrefs.SetFloat ("MilliSave", LTMs);

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;

		isBestTime = false;
		Debug.Log (LTMin);
		Debug.Log (MinuteCountBest);
		if (LTMin < MinuteCountBest) {
			isBestTime = true;
		} else if (LTMin == MinuteCountBest) {
			if (LTSec < SecondCountBest) {
				isBestTime = true;
			} else if (LTSec == SecondCountBest) { 
				if (LTMs  < MilliCountBest) {
					isBestTime = true;
				}
			}
		}

		Debug.Log (isBestTime);
		if (isBestTime==true) {
			MinuteCountBest = LTMin;
			SecondCountBest = LTSec;
			MilliCountBest = LTMs;
		}

		MilliDisplayBest = MilliCountBest.ToString ("F0");
		MilliBoxBest.GetComponent<Text> ().text = ""+MilliDisplayBest;
		if (SecondCountBest <= 9) {
			SecondBoxBest.GetComponent<Text> ().text = "0" + SecondCountBest + ".";
		} else {
			SecondBoxBest.GetComponent<Text> ().text = ""+ SecondCountBest+".";
		}

		if (SecondCountBest >= 60) {
			SecondCountBest = 0;
			MinuteCountBest += 1;
		}
		if (MinuteCountBest <= 9) {
			MinuteBoxBest.GetComponent<Text> ().text = "0" + MinuteCountBest + ":";
		} else {
			MinuteBoxBest.GetComponent<Text> ().text = ""+ MinuteCountBest+":";
		}

		LapCount.GetComponent<Text> ().text = "" + LapsDone;
		LapCompleteTrig.SetActive (false);
		HalfLapTrig.SetActive (true);
	}
}
