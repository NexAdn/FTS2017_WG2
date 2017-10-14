using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTrigger : MonoBehaviour {

    // Use this for initialization
    public PhoneDock phoneDock;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "Phone")
        {
            phoneDock.Dock();
        }


    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("exit");
        phoneDock.unDock();
    }
}
