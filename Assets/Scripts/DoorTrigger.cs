using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	// Use this for initialization
	public PhoneDock phoneDock;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider){
        Debug.Log(collider.tag);
        if(collider.tag == "Phone")
        {
            Debug.Log("hit");
            phoneDock.Dock();
        }


	}
}
