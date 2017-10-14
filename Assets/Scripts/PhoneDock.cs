using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.GrabAttachMechanics;
using VRTK;

public class PhoneDock : MonoBehaviour {

    // Use this for initialization
    public bool dock = true;
    public bool inside = false;
    public Transform Dockposition;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (dock && inside)
        {
            transform.position = Dockposition.position;
            transform.rotation = Dockposition.rotation;

            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<VRTK_InteractableObject>().isGrabbable = false;
            GetComponent<VRTK_ChildOfControllerGrabAttach>().StopGrab(false);
            inside = false;

            GetComponent<StateHandler>().UpdateScreen(2);
        }

    }

    public void toggle ()
    {
        dock = !dock;
        //Debug.Log(dock);
    }

    public void Dock()
    {

        //Debug.Log(dock);
        inside = true;
      /*  else
        {
            float Test = Controller.GetComponent<VRTK_ControllerEvents>().GetGripAxis();

            Debug.Log("Hand? = " + Test);

            GetComponent<VRTK_ChildOfControllerGrabAttach>().StopGrab(false);
            // GetComponent<VRTK_InteractableObject>().isGrabbable = false;
        }*/
    }
    public void unDock()
    {
        inside = false;
    }
}
