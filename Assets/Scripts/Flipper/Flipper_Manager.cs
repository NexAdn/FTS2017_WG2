using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Manager : MonoBehaviour {

    public float springStrength = 100;
    public AudioSource flipperLeftUpSound;
    public AudioSource flipperLeftDownSound;
    public AudioSource flipperRightUpSound;
    public AudioSource flipperRightDownSound;

    [SerializeField]
    private Rigidbody rightFlipper = null;

    [SerializeField]
    private Rigidbody leftFlipper = null;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 50, spring = springStrength, damper = 2 };

            flipperLeftUpSound.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -40, spring = springStrength, damper = 2 };

            flipperLeftDownSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -50, spring = springStrength, damper = 2 };

            flipperRightUpSound.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 40, spring = springStrength, damper = 2 };

            flipperRightDownSound.Play();
        }
    }


    public void leftButtonClick()
    {
        leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 50, spring = springStrength, damper = 2 };

        flipperLeftUpSound.Play();
    }

    public void leftButtonRelease()
    {
        leftFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -40, spring = springStrength, damper = 2 };

        flipperLeftDownSound.Play();
    }

    public void rightButtonClick()
    {
        rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = -50, spring = springStrength, damper = 2 };

        flipperRightUpSound.Play();
    }

    public void rightButtonRelease()
    {
        rightFlipper.GetComponent<HingeJoint>().spring = new JointSpring { targetPosition = 40, spring = springStrength, damper = 2 };

        flipperRightDownSound.Play();
    }
}
