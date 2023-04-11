using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour {

	void Start() {
		StartCoroutine (CreditFinish());
	}

	IEnumerator CreditFinish(){
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene(0);
	}

	/*
	 * public float TimeCount;
	// Update is called once per frame
	void Update () {
		TimeCount += Time.deltaTime;
		if(TimeCount >= 10){
			SceneManager.LoadScene(0);
		}
	}
	*/


}
