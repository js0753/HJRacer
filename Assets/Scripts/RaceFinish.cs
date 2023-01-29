using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject CarCam;
	public GameObject FinishCam;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public GameObject MiniMap;

	void OnTriggerEnter(){
		this.GetComponent<BoxCollider> ().enabled = false;
		MyCar.SetActive (false); // Why ?
		CompleteTrig.SetActive(false);
		CarController.m_Topspeed = 0.0f;
		MyCar.GetComponent<CarController> ().enabled = false;
		MyCar.GetComponent<CarUserControl> ().enabled = false;
		MyCar.SetActive (true);
		FinishCam.SetActive (true);
		LevelMusic.SetActive (false);
		CarCam.SetActive (false);
		MiniMap.SetActive (false);

	}

}
