using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CarChoice : MonoBehaviour {

	// Use this for initialization
	public GameObject RedBody;
	public GameObject BlueBody;
	public GameObject GreenBody;
	public int CarImport; // why?

	void Start () {
		CarImport = GlobalCar.CarType;
		if ( CarImport == 1){
			RedBody.SetActive (true);
			//BlueBody.SetActive (false);
		}else if(CarImport == 2){
			//RedBody.SetActive (false);
			BlueBody.SetActive (true);
		}else if(CarImport == 3){
			//RedBody.SetActive (false);
			GreenBody.SetActive (true);
		}

}
}
