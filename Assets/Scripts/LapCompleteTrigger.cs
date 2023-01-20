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

	public int MinuteCountBest;
	public int SecondCountBest;
	public float MilliCountBest;

	public string MilliDisplayBest;
	public int MinuteCountStart;
	public int SecondCountStart;
	public float MilliCountStart;
	public bool isBestTime;
	void Start(){
		MinuteCountBest= 9999;
		SecondCountBest= 9999;
		MilliCountBest= 9999;
		MinuteCountStart=0;
		SecondCountStart=0;
		MilliCountStart = 0;
		Debug.Log (MinuteCountBest);
	}
	void OnTriggerEnter(){
		int LTMin = LapTimeManager.MinuteCount;
		int LTSec = LapTimeManager.SecondCount;
		float LTMs = LapTimeManager.MilliCount;
		isBestTime = false;
		Debug.Log (LTMin);
		Debug.Log (MinuteCountBest);
		if (LTMin- MinuteCountStart < MinuteCountBest) {
			isBestTime = true;
		} else if (LTMin - MinuteCountStart == MinuteCountBest) {
			if (LTSec - SecondCountStart < SecondCountBest) {
				isBestTime = true;
			} else if (LTSec - SecondCountStart == SecondCountBest) { 
				if (LTMs - MilliCountStart < MilliCountBest) {
					isBestTime = true;
				}
			}
		}

		Debug.Log (isBestTime);
		if (isBestTime==true) {
			MinuteCountBest = LTMin- MinuteCountStart;
			SecondCountBest = LTSec- SecondCountStart;
			MilliCountBest = LTMs - MilliCountStart;
		}


		MilliCountBest += Time.deltaTime * 10;

		if (MilliCountBest >= 10) {
			MilliCountBest = 0;
			SecondCountBest += 1;
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
		MinuteCountStart=LTMin;
		SecondCountStart=LTSec;
		MilliCountStart = LTMs;
		LapCompleteTrig.SetActive (false);
		HalfLapTrig.SetActive (true);
	}
}
