using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class CarControls : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject Dreamcar01;
    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
    }

}
