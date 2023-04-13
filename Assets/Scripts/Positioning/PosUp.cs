using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PosUp : MonoBehaviour {

	public GameObject positionDisp;
	// Use this for initialization
	void OnTriggerExit(Collider other){
		if(other.tag == "CarPos")
		positionDisp.GetComponent<Text> ().text = "1st Place";
	}
}
