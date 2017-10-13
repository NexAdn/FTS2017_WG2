using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	public int TurningValue = 0;
	public int MaxTurningValue = 0;
	public float TurningSpeed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (TurningValue < MaxTurningValue) {
			transform.Rotate (Vector2.up, Time.deltaTime * TurningSpeed, Space.World);
			TurningValue += 1;

		}

	}
}
