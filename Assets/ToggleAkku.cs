using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAkku : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TurnOn()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
    public void TurnOff()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
