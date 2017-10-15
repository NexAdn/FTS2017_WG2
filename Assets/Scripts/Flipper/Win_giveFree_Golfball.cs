using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_giveFree_Golfball : MonoBehaviour {

    public GameObject golfHidePlane;
    public float giveBallFreeTimeAfterWin = 3f;
    private bool won = false;
    private float timeAfterWin = 0f;

    private void Update()
    {
        if (won)
        {
            timeAfterWin += Time.deltaTime;

            if (timeAfterWin > giveBallFreeTimeAfterWin)
            {
                golfHidePlane.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider maybeBall)
    {
        if (maybeBall.tag == "Flipper_Ball")
        {
            won = true;
        }
    }
}