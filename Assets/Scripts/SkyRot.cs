using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRot : MonoBehaviour {

	public float rotateSpeed = 0.5f;
	// Update is called once per frame
	void Update () {
		RenderSettings.skybox.SetFloat ("_Rotation", rotateSpeed* Time.time); // we multiply with Time.time, so that if speed of game is changed rotation speed is relative to that
	}
}
