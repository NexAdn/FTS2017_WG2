﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchrankTriggerl : MonoBehaviour {

    public PlaySchrankAnimation schrankAnimation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        schrankAnimation.Play();
    }
}
