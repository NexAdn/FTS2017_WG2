using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover_Respawn : MonoBehaviour {

    public Transform Ball;
    public Transform ballOrigin;
	
	void Update () {
		
	}


    void OnTriggerEnter(Collider maybeBall)
    {
        if (maybeBall.tag == "Flipper_Ball")
        {
            Ball.transform.position = new Vector3(ballOrigin.transform.position.x, ballOrigin.transform.position.y, ballOrigin.transform.position.z);
        }
    }
}