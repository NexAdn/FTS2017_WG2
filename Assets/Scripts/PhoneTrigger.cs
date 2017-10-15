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
    void OnTriggerStay(Collider collider)
    {
        //Debug.Log(collider.tag);
        /*if (collider.tag == "Phone")
        {
            phoneDock.Dock();
        }  */


    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Phone")
        {
            phoneDock.Dock();
        }
    }
    void OnTriggerExit(Collider collider)
    {
        //Debug.Log("exit");
        if (collider.tag == "Phone")
        {
            phoneDock.unDock();
        }
    }
}
