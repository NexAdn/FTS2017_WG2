using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class StateHandler : MonoBehaviour {

    public int gameState = 1;
    public Toggle spotlight;
    public TogglePin pin;
    public ToggleAkku akku;
    public Hochkant anchor;
    public PhoneDock Phone;

    private int m_CurrentState = 0;

	// Use this for initialization
	void Start () {
        UpdateScreen(gameState);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScreen(int gameState)
    {
        if (m_CurrentState > gameState) return;

        m_CurrentState = gameState;

        if (gameState == 1)
        {
            spotlight.toggleOn();
            akku.TurnOn();
            //anchor.setzeHochkant();

        } else if (gameState == 2)
        {
            akku.TurnOn();
            spotlight.toggleOff();
            //anchor.setzeHochkant();
        }
        else if (gameState == 3)
        {
         //   Phone.unDock();
            akku.TurnOff();
             spotlight.toggleOff();
             pin.TurnOn();
             //anchor.setzeHochkant();  
            akku.TurnOff();
            spotlight.toggleOff();
            pin.TurnOff();
            //anchor.setzeSeitwaerts(); 
        } else
        {
            Phone.unDock();
            akku.TurnOff();
            spotlight.toggleOff();
            pin.TurnOff();
            //anchor.setzeSeitwaerts();
        }
    }
}
