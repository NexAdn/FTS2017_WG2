using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Manager : MonoBehaviour {

    private Animator Animator;

	// Use this for initialization
	void Start () {
        Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Animator.SetTrigger("Launch");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Animator.SetBool("Flipperstick_left", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Animator.SetBool("Flipperstick_left", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Animator.SetBool("Flipperstick_right", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Animator.SetBool("Flipperstick_right", false);
        }
    }
}
