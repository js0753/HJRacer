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

	public GameObject RaceFinish;

	public int LapsDone;

	public bool isBestTime;

	public float RawTime;
	/*
	void Update(){
		Debug.Log (LapsDone);
		if (LapsDone == 2) {
			RaceFinish.SetActive (true);
		}
	}*/
	void OnTriggerEnter(Collider other){
		if (other.tag != "CarPos") {
			Debug.Log (other.tag);
		LapsDone += 1;
		Debug.Log (LapsDone);
		LapCount.GetComponent<Text> ().text = "" + LapsDone;
		int LTMin = LapTimeManager.MinuteCount;
		int LTSec = LapTimeManager.SecondCount;
		float LTMs = LapTimeManager.MilliCount;
		float LTRaw = LapTimeManager.RawTime;

		if (ModeSelect.RaceMode == 0 && LapsDone == 2) {
		RaceFinish.SetActive (true);
		}
		RawTime = PlayerPrefs.GetFloat ("RawTime",999999);
		Debug.Log ("PrevLap RAW TIMEE : "+RawTime.ToString("F0"));
		//Debug.Log (RawTime);
		//Debug.Log (RawTime == 0);
		if (LTRaw<RawTime || (int)RawTime==0) {
			//Debug.Log (LTRaw);
			//Debug.Log (RawTime);
			MilliBoxBest.GetComponent<Text> ().text = ""+LTMs.ToString ("F0");
			if (LTSec <= 9) {
				SecondBoxBest.GetComponent<Text> ().text = "0" + LTSec + ".";
			} else {
				SecondBoxBest.GetComponent<Text> ().text = ""+ LTSec+".";
			}

			if (LTSec >= 60) {
				LTSec = 0;
				LTMin += 1;
			}
			if (LTMin <= 9) {
				MinuteBoxBest.GetComponent<Text> ().text = "0" + LTMin + ":";
			} else {
				MinuteBoxBest.GetComponent<Text> ().text = ""+ LTMin+":";
			}
			PlayerPrefs.SetInt ("MinSave", LTMin);
			PlayerPrefs.SetInt ("SecSave", LTSec);
			PlayerPrefs.SetFloat ("MilliSave", LTMs);
			PlayerPrefs.SetFloat ("RawTime", LTRaw);
		}



		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.RawTime = 0;

		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);
	}
	}
}

/*
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
		}*/