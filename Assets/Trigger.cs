﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public StateHandler handy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {

        Debug.Log(collider.tag);
        if (collider.tag == "Golf_Ball")
        {
            handy.UpdateScreen(4);
            Debug.Log("hit");
        }
    }
}
