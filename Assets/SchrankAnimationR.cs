﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchrankAnimationR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Play()
    {
        GetComponent<Animator>().SetBool("Touched2", true);
    }
}
