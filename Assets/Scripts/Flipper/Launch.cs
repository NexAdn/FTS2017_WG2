using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {

    public Animator Animator;
    public Rigidbody Ball;
    public Transform forceVector;
    public float timeAfterLaunchAnimation = 0.5f;
    public float forceToBallAtLaunch = 0.5899f;
    private float triggerPause = 1f;
    private float timeSinceLaunchStart = 0f;
    private bool launchAnimationStarted = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (launchAnimationStarted)
        {
            timeSinceLaunchStart += Time.deltaTime;

            if (timeSinceLaunchStart > timeAfterLaunchAnimation)
            {
                launchAnimationStarted = false;
                timeSinceLaunchStart = 0f;

                Ball.AddForce(transform.up * forceToBallAtLaunch);
            }
        }
    }


    private void OnTriggerEnter(Collider maybeBall)
    {
        if (maybeBall.tag == "Flipper_Ball")
        {
            Animator.SetTrigger("Launch");
            launchAnimationStarted = true;
        }
    }
}
