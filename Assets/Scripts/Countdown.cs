using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	public AudioSource GetReady;
	public AudioSource GoAudio;

	public GameObject CarControls;
	public GameObject LapTimer;
	public GameObject CountDown;

	// Use this for initialization
	void Start () {
		StartCoroutine (CountStart ());
	}

	IEnumerator CountStart () {
		yield return new WaitForSeconds (0.5f);
		for (int i = 3; i >0; i--) {
			CountDown.GetComponent<Text>().text = "" + i;
			CountDown.SetActive (true);
			GetReady.Play ();
			yield return new WaitForSeconds (1);
			CountDown.SetActive (false);
		}
		GoAudio.Play ();
		CarControls.SetActive (true);
		LapTimer.SetActive (true);
	}
}
