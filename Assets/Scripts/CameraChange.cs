using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

	public GameObject NormalCam;
	public GameObject FarCam;
	public GameObject FPCam;
	public int CameraMode;
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Viewmode")) {
			if (CameraMode == 2) { // Not CameraMode == 3, as when CameraMode is 2 and then we press Viewmode button we want it to go to 0, 
				//if we keep it 3 it will go to 3 from 2 and after that again we have to press Viewmode button to go to 0.
				CameraMode = 0;
			} else {
				CameraMode += 1;
			}
			StartCoroutine (ModeChange ()); // A little doubt here
		}
	}

	IEnumerator ModeChange(){
		yield return new WaitForSeconds (0.01f); 
		if (CameraMode == 0) {
			NormalCam.SetActive (true);
			FPCam.SetActive (false);
		} else if (CameraMode == 1) {
			FarCam.SetActive (true);
			NormalCam.SetActive (false);
		} else {
			FPCam.SetActive (true);
			FarCam.SetActive (false);
		}
	}

}
