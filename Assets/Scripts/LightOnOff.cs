using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void On()
    {
        GetComponent<Light>().intensity = 0.8f;
    }
    public void Off()
    {
        GetComponent<Light>().intensity = 0f;
    }
}
