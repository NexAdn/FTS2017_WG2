using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.GrabAttachMechanics;
using VRTK;

public class PhoneDock : MonoBehaviour {

    // Use this for initialization
    public bool dock = true;
    public bool inside = false;
    public bool end = true;


    public bool m_IsDocked = false;
    public bool m_IsInside = false;


    public Transform Dockposition;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            unDock();
        }

        if (inside&&end)
        {
            Debug.Log("PhoneDock.Update: inside: " + inside + "end: " + end);
            //GetComponent<VRTK_ChildOfControllerGrabAttach>().StopGrab(false);
            //GetComponent<VRTK_InteractableObject>().isGrabbable = false;
            transform.position = Dockposition.position;
            transform.rotation = Dockposition.rotation;

            //GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;


            GetComponent<BoxCollider>().enabled = false;

            inside = false;
        }   
    }

    public void Dock()
    {
        Debug.Log("PhoneDock.Dock");
        m_IsDocked = true;

        Debug.Log(dock);
        inside = true;

        GetComponent<StateHandler>().UpdateScreen(2);
    }

    public void unDock()
    {
        if (!m_IsDocked) return;
        Debug.Log("PhoneDock.unDock");
        m_IsDocked = false;

        inside = false;
        end = false;

        //GetComponent<Rigidbody>().useGravity = false;
        GetComponent<VRTK_InteractableObject>().isGrabbable = true;
      
        //GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;


        GetComponent<BoxCollider>().enabled = true;
        // GetComponent<StateHandler>().UpdateScreen(3);
    }
}
