using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Manager : MonoBehaviour {
    
    private Animator Animator;

    public float springStrength = 100;

    [SerializeField]
    private Rigidbody rightFlipper = null;

    [SerializeField]
    private Rigidbody leftFlipper = null;

    // Use this for initialization
    void Start () {
        Animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 50, spring = springStrength, damper = 2 };
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -40, spring = springStrength, damper = 2 };
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -50, spring = springStrength, damper = 2 };
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 40, spring = springStrength, damper = 2 };
        }


        
    }
}
