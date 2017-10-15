using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class StateHandler : MonoBehaviour {

    public float gameState;
    public Toggle spotlight;
    public TogglePin pin;
    public ToggleAkku akku;

	// Use this for initialization
	void Start () {
        UpdateScreen(gameState);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScreen(float gameState)
    {
        if (gameState == 1)
        {
            spotlight.toggleOn();
            akku.TurnOn();

        } else if (gameState  ==2 )
        {
            akku.TurnOn();
            spotlight.toggleOff();
        }else if (gameState == 3)
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<VRTK_InteractableObject>().isGrabbable = true;
            akku.TurnOff();
            spotlight.toggleOff();
            pin.TurnOn();
        } else
        {
            akku.TurnOff();
            spotlight.toggleOff();
            pin.TurnOff();
        }
    }
}
