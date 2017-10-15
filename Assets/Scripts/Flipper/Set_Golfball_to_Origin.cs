using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Golfball_to_Origin : MonoBehaviour {

    public Transform golfBall;
    public Transform golfBallOrigin;

    // Use this for initialization
    void Start () {
        golfBall.transform.position = new Vector3(golfBallOrigin.transform.position.x, golfBallOrigin.transform.position.y, golfBallOrigin.transform.position.z);
    }
}
