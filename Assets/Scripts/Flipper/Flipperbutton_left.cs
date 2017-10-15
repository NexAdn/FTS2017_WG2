using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipperbutton_left : MonoBehaviour
{

    public Flipper_Manager FlipperManager;


    private void OnTriggerEnter(Collider other)
    {
        FlipperManager.leftButtonClick();
    }

    private void OnTriggerExit(Collider other)
    {
        FlipperManager.leftButtonRelease();
    }
}