using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {
	// Global static variable
	public static int CarType; // 1= Red
	public GameObject TrackWindow;

	public void RedCar(){
		CarType = 1;
		TrackWindow.SetActive (true);
	}

	public void BlueCar(){
		CarType = 2;
		TrackWindow.SetActive (true);
	}
}
