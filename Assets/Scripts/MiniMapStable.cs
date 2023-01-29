using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapStable : MonoBehaviour {

	public GameObject TheCar;
	public float CarX;
	public float CarY;
	public float CarZ;

	// Update is called once per frame
	void Update () {
		CarX = TheCar.transform.position.x;
		CarY = TheCar.transform.position.y;
		CarZ = TheCar.transform.position.z;

		transform.eulerAngles = new Vector3 (90, 0, 0);
		transform.position = new Vector3(CarX,62,CarZ);
	}
}
