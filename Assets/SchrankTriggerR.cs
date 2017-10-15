using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchrankTriggerR : MonoBehaviour {


    public SchrankAnimationR schrankAnimationR;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        schrankAnimationR.Play();
    }
}
