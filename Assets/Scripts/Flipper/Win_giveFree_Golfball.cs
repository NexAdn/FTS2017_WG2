using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_giveFree_Golfball : MonoBehaviour {

    public GameObject golfHidePlane;
    public float giveBallFreeTimeAfterWin = 3f;
    public Text flipperDisplay;
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

            flipperDisplay.text = "YOU WON A BALL!";
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