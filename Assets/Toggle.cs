﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toggleOn()
    {
        GetComponent<Light>().enabled = true;
    }
    public void toggleOff()
    {
        GetComponent<Light>().enabled = false;
    }
}
