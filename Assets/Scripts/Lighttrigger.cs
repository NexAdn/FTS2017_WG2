using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighttrigger : MonoBehaviour {

    public LightOnOff light;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider collider)
    {
        light.On();
    }
}
