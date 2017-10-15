using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Manager : MonoBehaviour {

    public float springStrength = 100;
    public Collider leftButton;
    public Collider rightButton;

    [SerializeField]
    private Rigidbody rightFlipper = null;

    [SerializeField]
    private Rigidbody leftFlipper = null;


    public void leftButtonClick()
    {
        leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 50, spring = springStrength, damper = 2 };
    }

    public void leftButtonRelease()
    {
        leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -40, spring = springStrength, damper = 2 };
    }

    public void rightButtonClick()
    {
        rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -50, spring = springStrength, damper = 2 };
    }

    public void rightButtonRelease()
    {
        rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 40, spring = springStrength, damper = 2 };
    }
}
