using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {
	// Global static variable
	public static int CarType; // 1= Red
	public GameObject ModeWindow;

	public void RedCar(){
		CarType = 1;
		ModeWindow.SetActive (true);
	}

	public void BlueCar(){
		CarType = 2;
		ModeWindow.SetActive (true);
	}
	public void GreenCar(){
		CarType = 3;
		ModeWindow.SetActive (true);
	}
}
