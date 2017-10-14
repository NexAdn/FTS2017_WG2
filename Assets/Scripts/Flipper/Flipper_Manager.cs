using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Manager : MonoBehaviour {

    public float timeAfterLaunchAnimation = 0.5f;
    public float forceToBallAtLaunch = 1f;
    public Transform forceVector;
    public Rigidbody Ball;
    private Animator Animator;
    private float timeSinceLaunchStart = 0;
    private bool launchAnimationStarted = false;
    

	// Use this for initialization
	void Start () {
        Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Animator.SetTrigger("Launch");
            launchAnimationStarted = true;
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


        if (launchAnimationStarted)
        {
            timeSinceLaunchStart += Time.deltaTime;

            if (timeSinceLaunchStart > timeAfterLaunchAnimation)
            {
                launchAnimationStarted = false;
                timeSinceLaunchStart = 0f;

                Ball.AddForce(forceVector.rotation.ToEulerAngles() * forceToBallAtLaunch);
            }
        }
    }
}
