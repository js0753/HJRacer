﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour {

	public static int RaceMode; //0=Race 1=ScoreMode 2=TimeMode
	public GameObject TrackWindow;
	public void ScoreMode(){
		RaceMode = 1;
		TrackWindow.SetActive (true);
	}

	public void TimeMode(){
		RaceMode = 2;
		TrackWindow.SetActive (true);
	}

	public void TheRaceMode(){
		RaceMode = 0;
		TrackWindow.SetActive (true);
	}
}
