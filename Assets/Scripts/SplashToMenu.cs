using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (ToMenu ());
	}

	IEnumerator ToMenu(){
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene (1);
	}
}
